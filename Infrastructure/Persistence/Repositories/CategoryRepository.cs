using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ElmsDbContext _context;

        public CategoryRepository(ElmsDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>>   GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}