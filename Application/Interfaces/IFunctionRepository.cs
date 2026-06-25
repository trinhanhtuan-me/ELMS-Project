using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IFunctionRepository
    {
        Task<IEnumerable<PFunction>> FindUserFunctions(Guid userId);
        Task<IEnumerable<PFunction>> FindFunctionsByIds(IEnumerable<int> ids);
        Task<IEnumerable<PFunction>> GetAllFunctions();
    }
}
