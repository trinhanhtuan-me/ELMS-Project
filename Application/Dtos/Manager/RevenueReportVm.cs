using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Manager
{
    public class RevenueReportVm
    {
        public string Label { get; set; } = null!;
        public int Year { get; set; }

        public int Month { get; set; }
        public int CoursesSold { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}
