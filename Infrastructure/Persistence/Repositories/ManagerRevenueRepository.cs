using Application.Dtos.Manager;
using Application.Interfaces;
using Domain.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Manager
{
    public class ManagerRevenueRepository(ElmsDbContext _context) : IManagerRevenueRepository
    {
        public async Task<List<RevenueReportVm>> GetYearlyReportAsync()
        {
            var currentYear = DateTime.Now.Year;
            var startYear = currentYear - 4; 

            var data = await _context.Orders
                .Where(o => o.Status == OrderStatus.Paid && o.CreatedAt.Year >= startYear)
                .SelectMany(o => o.OrderItems, (o, i) => new { o.CreatedAt.Year, i.PriceVnd })
                .GroupBy(x => x.Year)
                .Select(g => new
                {
                    Year = g.Key,
                    CoursesSold = g.Count(),
                    TotalRevenue = g.Sum(x => x.PriceVnd)
                })
                .ToListAsync();

            var result = new List<RevenueReportVm>();
            for (int i = startYear; i <= currentYear; i++)
            {
                var yearData = data.FirstOrDefault(d => d.Year == i);
                result.Add(new RevenueReportVm
                {
                    Label = i.ToString(),
                    Year = i,
                    Month = 0,
                    CoursesSold = yearData?.CoursesSold ?? 0,
                    TotalRevenue = yearData?.TotalRevenue ?? 0
                });
            }

            return result;
        }

        public async Task<List<RevenueReportVm>> GetMonthlyReportAsync(int year)
        {
            var data = await _context.Orders
                .Where(o => o.Status == OrderStatus.Paid && o.CreatedAt.Year == year)
                .SelectMany(o => o.OrderItems, (o, i) => new { o.CreatedAt.Month, i.PriceVnd })
                .GroupBy(x => x.Month)
                .Select(g => new
                {
                    Month = g.Key,
                    CoursesSold = g.Count(),
                    TotalRevenue = g.Sum(x => x.PriceVnd)
                })
                .ToListAsync();

            var result = new List<RevenueReportVm>();

            for (int i = 1; i <= 12; i++)
            {
                var monthData = data.FirstOrDefault(d => d.Month == i);
                result.Add(new RevenueReportVm
                {
                    Label = $"M{i}/{year}", 
                    Year = year,
                    Month = i,
                    CoursesSold = monthData?.CoursesSold ?? 0,
                    TotalRevenue = monthData?.TotalRevenue ?? 0
                });
            }

            return result;
        }
    }
}
