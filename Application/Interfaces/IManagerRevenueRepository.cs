using Application.Dtos.Manager;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IManagerRevenueRepository
{
    Task<List<RevenueReportVm>> GetYearlyReportAsync();
    Task<List<RevenueReportVm>> GetMonthlyReportAsync(int year);
}
