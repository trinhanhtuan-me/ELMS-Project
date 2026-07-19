using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories;

public class PaymentRepository(ElmsDbContext context) : IPaymentRepository
{
    public async Task<Payment?> GetByTxnRefAsync(string txnRef)
    {
        return await context.Payments
            .FirstOrDefaultAsync(p => p.TxnRef == txnRef);
    }

    public async Task<Payment?> GetByOrderIdAsync(Guid orderId)
    {
        return await context.Payments
            .FirstOrDefaultAsync(p => p.OrderId == orderId);
    }

    public async Task AddAsync(Payment payment)
    {
        await context.Payments.AddAsync(payment);
    }

    public void Update(Payment payment)
    {
        context.Payments.Update(payment);
    }
}
