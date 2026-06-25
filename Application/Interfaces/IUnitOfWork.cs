using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task BeginAsync(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);
        Task CommitAsync();
        Task RollBackAsync();
        Task<int> SaveChangeAsync();
    }
}
