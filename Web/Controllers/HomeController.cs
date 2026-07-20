using Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;
        public HomeController(IHomeService courseService)
        {
            _homeService = courseService;
        }
        public async Task<IActionResult> Index()
        {
            var homeData = await _homeService.GetHomeDataAsync();
            return View(homeData);
        }
    }
}
