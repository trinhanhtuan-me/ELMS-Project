using Application.Dtos.Manager;
using Application.Interfaces;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public interface IManagerRevenueService
    {
        Task<List<RevenueReportVm>> GetYearlyReportAsync();
        Task<List<RevenueReportVm>> GetMonthlyReportAsync(int year);
        byte[] GenerateCsvBytes(List<RevenueReportVm> reports, string type);
    }

    public class ManagerRevenueService(IManagerRevenueRepository _revenueRepo) : IManagerRevenueService
    {
        public async Task<List<RevenueReportVm>> GetYearlyReportAsync()
        {
            return await _revenueRepo.GetYearlyReportAsync();
        }

        public async Task<List<RevenueReportVm>> GetMonthlyReportAsync(int year)
        {
            return await _revenueRepo.GetMonthlyReportAsync(year);
        }

        public byte[] GenerateCsvBytes(List<RevenueReportVm> reports, string type)
        {
            var sb = new StringBuilder();

            sb.AppendLine("Period,Courses Sold,Revenue (VND)");

            foreach (var report in reports)
            {
                sb.AppendLine($"{report.Label},{report.CoursesSold},{report.TotalRevenue}");
            }

            var bom = new byte[] { 0xEF, 0xBB, 0xBF };
            var csvBytes = Encoding.UTF8.GetBytes(sb.ToString());

            var finalBytes = new byte[bom.Length + csvBytes.Length];
            bom.CopyTo(finalBytes, 0);
            csvBytes.CopyTo(finalBytes, bom.Length);

            return finalBytes;
        }
    }
}
