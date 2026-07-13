using Application.Dtos.Manager;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IManagerCategoryRepository
{
    Task<List<CategoryVm>> GetAllCategoriesAsync();
    Task<bool> IsDuplicateNameAsync(string name, int? excludeId = null);
    Task<bool> SaveCategoryAsync(CategorySaveRequest request, string picturePath);
    Task<bool> HasCoursesAsync(int id);
    Task<bool> DeleteCategoryAsync(int id);
}
