using Application.Dtos.Manager;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories;

public class ManagerCategoryRepository(ElmsDbContext _context) : IManagerCategoryRepository
{
    public async Task<List<CategoryVm>> GetAllCategoriesAsync()
    {
        return await _context.Categories
            .OrderByDescending(c => c.Id)
            .Select(c => new CategoryVm
            {
                CategoryId = c.Id,
                Name = c.Name,
                Description = c.Description,
                Picture = c.Picture
            })
            .ToListAsync();
    }

    public async Task<bool> IsDuplicateNameAsync(string name, int? excludeId = null)
    {
        return await _context.Categories
            .AnyAsync(c => c.Name.ToLower() == name.ToLower() && c.Id != excludeId);
    }

    public async Task<bool> SaveCategoryAsync(CategorySaveRequest request, string picturePath)
    {
        if (request.Id.HasValue && request.Id.Value > 0)
        {
            var category = await _context.Categories.FindAsync(request.Id.Value);
            if (category == null) return false;

            category.Name = request.Name;
            category.Description = request.Description;
            category.Picture = picturePath;
            _context.Categories.Update(category);
        }
        else
        {
            var category = new Category
            {
                Name = request.Name,
                Description = request.Description,
                Picture = picturePath
            };
            _context.Categories.Add(category);
        }

        return true;
    }

    public async Task<bool> HasCoursesAsync(int id)
    {
        return await _context.Courses.AnyAsync(c => c.CategoryId == id && !c.IsDeleted);
    }
    public async Task<bool> DeleteCategoryAsync(int id)
    {
        var category = await _context.Categories.FindAsync(id);
        if (category == null) return false;

        _context.Categories.Remove(category);
        return true;
    }

}
