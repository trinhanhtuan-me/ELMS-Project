using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IOrderRepository
{
    Task<Order?> GetByIdAsync(Guid id);
    Task<List<Order>> GetPaidOrdersByParentAsync(Guid parentId, int pageNumber, int pageSize);
    Task<int> CountOrdersByParentAsync(Guid parentId);
    Task AddAsync(Order order);
    void Update(Order order);
}
