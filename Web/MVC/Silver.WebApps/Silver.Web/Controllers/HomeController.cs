using Microsoft.AspNetCore.Mvc;
using Silver.Web.Services;
using Silver.Web.ViewModels;
using System.Diagnostics;

namespace Silver.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService categoryService;

        public HomeController(
            ILogger<HomeController> logger,
            ICategoryService categoryService
            )
        {
            _logger = logger;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}