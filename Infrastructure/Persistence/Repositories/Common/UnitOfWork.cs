using Application.Common.Interfaces;
using Application.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System.Data;


namespace Infrastructure.Persistence.Repositories.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ElmsDbContext _context;
        private IDbContextTransaction? _transaction;

        public UnitOfWork(ElmsDbContext context)
        {
            _context = context;
        }
        public async Task BeginAsync(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            try
            {
                await _context.SaveChangesAsync();

                // Nếu BeginAsync được gọi trước đó, thì commit nó
                if (_transaction != null)
                {
                    await _transaction.CommitAsync();
                }
            }
            catch
            {
                await RollBackAsync();
                throw;
            }
            finally
            {
                if (_transaction != null)
                {
                    await _transaction.DisposeAsync();
                    _transaction = null;
                }
            }
        }

        public async Task RollBackAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
