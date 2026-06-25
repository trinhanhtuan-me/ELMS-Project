using Application.Dtos.Role;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IFunctionService
    {
        Task<List<FunctionCategoryInfoVm>> GetAllFunctionsGroupedByCategory();
    }

    public class FunctionService(IFunctionRepository _function) : IFunctionService
    {
        public async Task<List<FunctionCategoryInfoVm>> GetAllFunctionsGroupedByCategory()
        {
            var functions = await _function.GetAllFunctions();
            var result = functions.GroupBy(f => f.Category)
                 .Select(group => new FunctionCategoryInfoVm(
                     CategoryId: group.Key.Id,
                     CategoryDecription: group.Key.Description ?? string.Empty,
                     Functions: group.Select(f => new FunctionDetailVm(
                        FunctionId: f.Id,
                        FunctionDescription: f.Description ?? f.PermissionKey
                    )).ToList()
                 )).ToList();

            return result;
        }
    }
}
