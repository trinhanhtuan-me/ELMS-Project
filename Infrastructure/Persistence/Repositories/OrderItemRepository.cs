using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories;

public class OrderItemRepository(ElmsDbContext context) : IOrderItemRepository
{
    public async Task AddAsync(OrderItem item)
    {
        await context.OrderItems.AddAsync(item);
    }
}
