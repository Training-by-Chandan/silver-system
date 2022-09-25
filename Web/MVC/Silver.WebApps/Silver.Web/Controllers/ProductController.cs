using Microsoft.AspNetCore.Mvc;
using Silver.Web.Services;
using Silver.Web.ViewModels;

namespace Silver.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductController(
            IProductService productService,
            ICategoryService categoryService
            )
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var data = productService.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            ViewBag.categoryList = categoryService.GetDropDown();
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var res = productService.Create(model);
                if (res.Item1)
                {
                    return RedirectToAction("Index");
                }
            }
            ViewBag.categoryList = categoryService.GetDropDown();
            return View(model);
        }
    }
}