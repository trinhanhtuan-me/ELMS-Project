using Application.Common.Interfaces;
using Application.Dtos.Manager;
using Application.Exceptions;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IManagerCategoryService
    {
        Task<List<CategoryVm>> GetAllCategoriesAsync();
        Task<bool> SaveCategoryAsync(CategorySaveRequest request);
        Task<bool> DeleteCategoryAsync(int id);
    }

    public class ManagerCategoryService(IManagerCategoryRepository _repo, IUnitOfWork _unitOfWork, IFileStorageService _fileStorageService) : IManagerCategoryService
    {
        public async Task<List<CategoryVm>> GetAllCategoriesAsync()
        {
            return await _repo.GetAllCategoriesAsync();
        }

        public async Task<bool> SaveCategoryAsync(CategorySaveRequest request)
        {
            if (await _repo.IsDuplicateNameAsync(request.Name, request.Id))
            {
                throw new BusinessRuleException("Duplicate name category!");
            }

            string picturePath = request.PictureOld ?? "";

            if (request.PictureFile != null && request.PictureFile.Length > 0)
            {
         
                var uploadedUrl = await _fileStorageService.SaveFileAsync(request.PictureFile, "elms-avaCourse");

                if (!string.IsNullOrEmpty(uploadedUrl))
                {
                    picturePath = uploadedUrl;
                }
            }

            var isTracked = await _repo.SaveCategoryAsync(request, picturePath);

            if (isTracked)
            {
                await _unitOfWork.SaveChangeAsync();
                return true;
            }

            throw new BusinessRuleException("Not Found Category!");
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            if (await _repo.HasCoursesAsync(id))
            {
                throw new BusinessRuleException("Cannot delete this category because it contains active courses!");
            }
            var isTracked = await _repo.DeleteCategoryAsync(id);
            if (isTracked)
            {
                await _unitOfWork.SaveChangeAsync();
                return true;
            }
            throw new BusinessRuleException("System Error: Category not found!");
        }
    }
}
