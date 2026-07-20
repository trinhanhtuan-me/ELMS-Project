using Application.Interfaces;
using Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICatalogService _catalogService;
        private readonly ICategoryService _categoryService;
        public CatalogController(ICatalogService catalogService, ICategoryService categoryService)
        {
            _catalogService = catalogService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index(string? keyword, List<int>? categoryIds, List<string>? languages, List<string>? levels, string sortBy = "popular", int page = 1)
        {
            int pageSize = 9; 

            var result = await _catalogService.SearchCatalogAsync(keyword, categoryIds, languages, levels, sortBy, page, pageSize);

            //Gan view bag giu trang thai
            ViewBag.Keyword = keyword;
            ViewBag.SelectedCategories = categoryIds ?? new List<int>();
            ViewBag.SelectedLanguages = languages ?? new List<string>();
            ViewBag.SelectedLevels = levels ?? new List<string>();
            ViewBag.SortBy = sortBy;
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling(result.Total / (double)pageSize);

            //lay language + level
            var filterOptions = await _catalogService.GetFilterOptionsAsync();

            ViewBag.AllCategories = await _categoryService.GetAllCategoriesAsync();
            ViewBag.AllLanguages = filterOptions.Languages;
            ViewBag.AllLevels = filterOptions.Levels;

            return View(result.Data);
        }
    }
}
