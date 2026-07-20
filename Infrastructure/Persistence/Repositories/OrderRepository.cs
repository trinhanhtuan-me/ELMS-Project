using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories;

public class OrderRepository(ElmsDbContext context) : IOrderRepository
{
    public async Task<Order?> GetByIdAsync(Guid id)
    {
        return await context.Orders
            .Include(o => o.Parent)
                .ThenInclude(p => p.IdNavigation)
            .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Course)
            .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Student)
                    .ThenInclude(s => s.IdNavigation)
            .FirstOrDefaultAsync(o => o.Id == id);
    }

    public async Task<List<Order>> GetPaidOrdersByParentAsync(Guid parentId, int pageNumber, int pageSize)
    {
        return await context.Orders
            .Include(o => o.OrderItems)
            .Where(o => o.ParentId == parentId && o.Status == OrderStatus.Paid)
            .OrderByDescending(o => o.CreatedAt)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<int> CountOrdersByParentAsync(Guid parentId)
    {
        return await context.Orders
            .Where(o => o.ParentId == parentId)
            .CountAsync();
    }

    public async Task AddAsync(Order order)
    {
        await context.Orders.AddAsync(order);
    }

    public void Update(Order order)
    {
        context.Orders.Update(order);
    }
}
