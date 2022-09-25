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
        private readonly IProductService productService;

        public HomeController(
            ILogger<HomeController> logger,
            ICategoryService categoryService,
            IProductService productService
            )
        {
            _logger = logger;
            this.categoryService = categoryService;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            var data = productService.GetAll();
            return View(data);
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