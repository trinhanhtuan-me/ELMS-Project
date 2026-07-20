using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IPaymentRepository
{
    Task<Payment?> GetByTxnRefAsync(string txnRef);
    Task<Payment?> GetByOrderIdAsync(Guid orderId);
    Task AddAsync(Payment payment);
    void Update(Payment payment);
}
