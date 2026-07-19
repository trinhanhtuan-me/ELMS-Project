using Domain.Entities;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IOrderItemRepository
{
    Task AddAsync(OrderItem item);
}
