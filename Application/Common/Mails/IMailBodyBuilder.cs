using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mails
{
    public interface IMailBodyBuilder
    {
        Task<string> BuildOtpRegistrationEmail(string userName, string otpCode);
        Task<string> BuildOtpForgotPassword(string userName, string otpCode);

        Task<string> BuildPaymentSuccessParentEmail(string parentName, Guid orderId, string itemsHtml, decimal totalAmount, string txnRef, DateTime capturedAt);
        Task<string> BuildCourseActivationStudentEmail(string studentName, string courseTitle, string courseUrl);

    }
}
