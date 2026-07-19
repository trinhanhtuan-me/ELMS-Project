using Application.Common;
using Application.Common.Interfaces;
using Application.Common.Mails;
using Application.Dtos.Billing;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases;

public interface IPaymentService
{
    Task<List<CourseRequestResponseDto>> GetUnpaidRequestsForParentAsync(Guid parentId);
    Task<string> CreateOrderAndInitiatePaymentAsync(Guid parentId, List<Guid> requestIds, string ipAddress, string returnUrl);
    Task<bool> ProcessVNPayReturnAsync(Dictionary<string, string> vnpayParams);
    Task<PaginatedList<OrderResponseDto>> GetOrdersForParentAsync(Guid parentId, int pageNumber, int pageSize);
    Task<OrderDetailResponseDto> GetOrderDetailsAsync(Guid parentId, Guid orderId);
}

public class PaymentService : IPaymentService
{
    private readonly ICourseRequestRepository _courseRequestRepository;
    private readonly IOrderRepository _orderRepository;
    private readonly IOrderItemRepository _orderItemRepository;
    private readonly IPaymentRepository _paymentRepository;
    private readonly IEnrollmentRepository _enrollmentRepository;
    private readonly IVNPayService _vnpayService;
    private readonly IMailRepository _mailRepository;
    private readonly IMailBodyBuilder _mailBodyBuilder;
    private readonly ILogger<PaymentService> _logger;
    private readonly IUnitOfWork _uow;

    public PaymentService(
        ICourseRequestRepository courseRequestRepository,
        IOrderRepository orderRepository,
        IOrderItemRepository orderItemRepository,
        IPaymentRepository paymentRepository,
        IEnrollmentRepository enrollmentRepository,
        IVNPayService vnpayService,
        IMailRepository mailRepository,
        IMailBodyBuilder mailBodyBuilder,
        ILogger<PaymentService> logger,
        IUnitOfWork uow)
    {
        _courseRequestRepository = courseRequestRepository;
        _orderRepository = orderRepository;
        _orderItemRepository = orderItemRepository;
        _paymentRepository = paymentRepository;
        _enrollmentRepository = enrollmentRepository;
        _vnpayService = vnpayService;
        _mailRepository = mailRepository;
        _mailBodyBuilder = mailBodyBuilder;
        _logger = logger;
        _uow = uow;

    }

    public async Task<List<CourseRequestResponseDto>> GetUnpaidRequestsForParentAsync(Guid parentId)
    {
        var requests = await _courseRequestRepository.GetRequestsByParentAndStatusAsync(parentId, CourseRequestStatus.Unpaid, 1, 100);
        return requests.Select(r => new CourseRequestResponseDto
        {
            RequestId = r.Id,
            StudentId = r.StudentId,
            StudentName = r.Student.IdNavigation.FullName ?? r.Student.IdNavigation.Username,
            StudentEmail = r.Student.IdNavigation.Email,
            CourseId = r.CourseId,
            CourseName = r.Course.Title,
            PriceVnd = r.Course.CoursePrice?.PriceAmount ?? 0,
            Status = r.Status,
            Note = r.Note,
            CreatedAt = r.CreatedAt,
            DecidedAt = r.DecidedAt
        }).ToList();
    }

    public async Task<string> CreateOrderAndInitiatePaymentAsync(Guid parentId, List<Guid> requestIds, string ipAddress, string returnUrl)
    {
        if (requestIds == null || requestIds.Count == 0)
            throw new BusinessRuleException("Danh sách yêu cầu thanh toán không được để trống.");

        decimal totalAmount = 0;
        var validRequests = new List<CourseRequest>();

        foreach (var reqId in requestIds)
        {
            var req = await _courseRequestRepository.GetByIdAsync(reqId);
            if (req != null && req.ParentId == parentId && req.Status == CourseRequestStatus.Unpaid)
            {
                validRequests.Add(req);
                totalAmount += req.Course.CoursePrice?.PriceAmount ?? 0;
            }
        }

        if (validRequests.Count == 0)
            throw new BusinessRuleException("Không tìm thấy yêu cầu thanh toán hợp lệ hoặc các yêu cầu đã được thanh toán trước đó.");

        await _uow.BeginAsync();
        try
        {
            var order = new Order
            {
                ParentId = parentId,
                Status = OrderStatus.Pending,
                PaymentMethod = PaymentMethod.EWallet,
                PaidAt = null,
                CreatedAt = DateTime.UtcNow
            };
            await _orderRepository.AddAsync(order);

            foreach (var req in validRequests)
            {
                var price = req.Course.CoursePrice?.PriceAmount ?? 0;
                var orderItem = new OrderItem
                {
                    OrderId = order.Id,
                    RequestId = req.Id,
                    CourseId = req.CourseId,
                    StudentId = req.StudentId,
                    PriceVnd = price
                };
                await _orderItemRepository.AddAsync(orderItem);
            }

            var txnRef = $"ORD_{order.Id.ToString().Replace("-", "")}";

            var payment = new Payment
            {
                OrderId = order.Id,
                AmountVnd = totalAmount,
                PaymentMethod = PaymentMethod.EWallet,
                Status = PaymentStatus.Initiated,
                TxnRef = txnRef,
                CapturedAt = null,
                CreatedAt = DateTime.UtcNow
            };
            await _paymentRepository.AddAsync(payment);

            await _uow.CommitAsync();

            var orderInfo = $"Thanh toan don hang {order.Id}";
            var paymentUrl = _vnpayService.CreatePaymentUrl(txnRef, totalAmount, ipAddress, returnUrl, orderInfo);

            return paymentUrl;
        }
        catch
        {
            await _uow.RollBackAsync();
            throw;
        }
    }

    public async Task<bool> ProcessVNPayReturnAsync(Dictionary<string, string> vnpayParams)
    {
        if (!_vnpayService.VerifySignature(vnpayParams))
            throw new BusinessRuleException("Chữ ký phản hồi từ VNPay không hợp lệ.");

        vnpayParams.TryGetValue("vnp_TxnRef", out var txnRef);
        vnpayParams.TryGetValue("vnp_ResponseCode", out var responseCode);

        if (string.IsNullOrEmpty(txnRef))
            throw new BusinessRuleException("Không tìm thấy mã tham chiếu giao dịch.");

        var payment = await _paymentRepository.GetByTxnRefAsync(txnRef);
        if (payment == null)
            throw new BusinessRuleException("Không tìm thấy giao dịch tương ứng trong hệ thống.");

        var order = await _orderRepository.GetByIdAsync(payment.OrderId);
        if (order == null)
            throw new BusinessRuleException("Không tìm thấy đơn hàng của giao dịch.");

        if (payment.Status != PaymentStatus.Initiated)
        {
            return payment.Status == PaymentStatus.Captured;
        }

        bool success = "00".Equals(responseCode);

        await _uow.BeginAsync();
        try
        {
            if (success)
            {
                payment.Status = PaymentStatus.Captured;
                payment.CapturedAt = DateTime.UtcNow;
                _paymentRepository.Update(payment);

                order.Status = OrderStatus.Paid;
                order.PaidAt = DateTime.UtcNow;
                _orderRepository.Update(order);

                foreach (var orderItem in order.OrderItems)
                {
                    if (orderItem.RequestId.HasValue)
                    {
                        var cr = await _courseRequestRepository.GetByIdAsync(orderItem.RequestId.Value);
                        if (cr != null && cr.Status == CourseRequestStatus.Unpaid)
                        {
                            cr.Status = CourseRequestStatus.Approved;
                            cr.DecidedAt = DateTime.UtcNow;
                            cr.Note = "Phụ huynh đã thanh toán thành công qua VNPay.";
                            _courseRequestRepository.Update(cr);
                        }
                    }

                    var isEnrolled = await _enrollmentRepository.IsEnrolledAsync(orderItem.CourseId, orderItem.StudentId);
                    if (!isEnrolled)
                    {
                        var enrollment = new Enrollment
                        {
                            CourseId = orderItem.CourseId,
                            StudentId = orderItem.StudentId,
                            EnrolledAt = DateTime.UtcNow,
                            Status = EnrollmentStatus.Active
                        };
                        await _enrollmentRepository.AddAsync(enrollment);
                    }
                }
                await SendPaymentSuccessEmailAsync(order, payment);
                await SendCourseActivationEmailToStudentsAsync(order);

                await _uow.CommitAsync();


                return true;
            }
            else
            {
                payment.Status = PaymentStatus.Failed;
                _paymentRepository.Update(payment);

                order.Status = OrderStatus.Cancelled;
                _orderRepository.Update(order);

                await _uow.CommitAsync();
                return false;
            }
        }
        catch
        {
            await _uow.RollBackAsync();
            throw;
        }
    }

    public async Task<PaginatedList<OrderResponseDto>> GetOrdersForParentAsync(Guid parentId, int pageNumber, int pageSize)
    {
        var pageNum = pageNumber <= 0 ? 1 : pageNumber;
        var size = pageSize <= 0 ? 10 : pageSize;

        var orders = await _orderRepository.GetPaidOrdersByParentAsync(parentId, pageNum, size);
        var count = await _orderRepository.CountOrdersByParentAsync(parentId);

        var data = orders.Select(o => new OrderResponseDto
        {
            OrderId = o.Id,
            Status = o.Status,
            PaymentMethod = o.PaymentMethod,
            PaidAt = o.PaidAt,
            CreatedAt = o.CreatedAt,
            CourseCount = o.OrderItems.Count,
            TotalAmountVnd = o.OrderItems.Sum(oi => oi.PriceVnd)
        }).ToList();

        return new PaginatedList<OrderResponseDto>(count, data);
    }

    public async Task<OrderDetailResponseDto> GetOrderDetailsAsync(Guid parentId, Guid orderId)
    {
        var order = await _orderRepository.GetByIdAsync(orderId);
        if (order == null || order.ParentId != parentId)
            throw new BusinessRuleException("Đơn hàng không tồn tại.");

        var payment = await _paymentRepository.GetByOrderIdAsync(orderId);

        var dto = new OrderDetailResponseDto
        {
            OrderId = order.Id,
            Status = order.Status,
            PaymentMethod = order.PaymentMethod,
            PaidAt = order.PaidAt,
            CreatedAt = order.CreatedAt,
            TotalAmountVnd = order.OrderItems.Sum(oi => oi.PriceVnd),
            TxnRef = payment?.TxnRef,
            CapturedAt = payment?.CapturedAt,
            Items = order.OrderItems.Select(oi => new OrderItemDetailDto
            {
                CourseName = oi.Course.Title,
                StudentName = oi.Student.IdNavigation.FullName ?? oi.Student.IdNavigation.Username,
                PriceVnd = oi.PriceVnd
            }).ToList()
        };

        return dto;
    }

    //Helper methods for sending emails
    private async Task SendPaymentSuccessEmailAsync(Order order, Payment payment)
    {
        try
        {
            var parentUser = order.Parent.IdNavigation;
            var parentEmail = parentUser.Email;
            if (string.IsNullOrEmpty(parentEmail)) return;

            // 1. Tạo chuỗi HTML động cho danh sách các khóa học
            var itemsHtml = new StringBuilder();
            foreach (var item in order.OrderItems)
            {
                itemsHtml.Append($@"
            <tr>
                <td style=""padding: 10px; border-bottom: 1px solid #eee;"">{item.Course.Title}</td>
                <td style=""padding: 10px; border-bottom: 1px solid #eee;"">{item.Student.IdNavigation.FullName ?? item.Student.IdNavigation.Username}</td>
                <td style=""padding: 10px; border-bottom: 1px solid #eee; text-align: right;"">{item.PriceVnd:N0} VND</td>
            </tr>");
            }

            // 2. Gọi MailBodyBuilder để dựng HTML từ template file
            var htmlBody = await _mailBodyBuilder.BuildPaymentSuccessParentEmail(
                parentUser.FullName ?? parentUser.Username,
                order.Id,
                itemsHtml.ToString(),
                payment.AmountVnd,
                payment.TxnRef,
                payment.CapturedAt ?? DateTime.UtcNow
            );

            // 3. Đưa vào hàng đợi
            var mail = new Mail
            {
                To = parentEmail,
                Subject = "EnglishLMS: Xác nhận thanh toán học phí thành công",
                Body = htmlBody,
                Status = MailStatus.Pending
            };
            await _mailRepository.AddAsync(mail);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Lỗi khi hàng đợi gửi mail hóa đơn cho Phụ huynh.");
        }
    }

    private async Task SendCourseActivationEmailToStudentsAsync(Order order)
    {
        try
        {
            foreach (var item in order.OrderItems)
            {
                var studentUser = item.Student.IdNavigation;
                var studentEmail = studentUser.Email;
                if (string.IsNullOrEmpty(studentEmail)) continue;

                var studentName = studentUser.FullName ?? studentUser.Username;
                var courseTitle = item.Course.Title;
                var courseUrl = $"http://localhost:5000/courses/{item.CourseId}"; 

                // Gọi MailBodyBuilder để dựng HTML từ file template kích hoạt của học sinh
                var htmlBody = await _mailBodyBuilder.BuildCourseActivationStudentEmail(
                    studentName,
                    courseTitle,
                    courseUrl
                );

                var mail = new Mail
                {
                    To = studentEmail,
                    Subject = $"[EnglishLMS] Khóa học '{courseTitle}' của bạn đã sẵn sàng!",
                    Body = htmlBody,
                    Status = MailStatus.Pending
                };
                await _mailRepository.AddAsync(mail);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Lỗi khi hàng đợi gửi mail kích hoạt khóa học cho Học sinh.");
        }
    }

}
