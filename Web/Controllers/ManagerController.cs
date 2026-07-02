using Application.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Web.Controllers
{
    // [Authorize(Roles = "Manager")] 
    [Route("manager")]
    public class ManagerController(IManagerDashboardService _dashboardService) : Controller
    {
        [HttpGet("dashboard")]
        public async Task<IActionResult> Dashboard()
        {
            var dashboardData = await _dashboardService.GetDashboardAsync();
            return View(dashboardData);
        }

        // TODO: Các Action duyệt/từ chối/xuất bản khoá học (Approve/Reject/Publish/Unpublish)
    }
}
