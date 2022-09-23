using Microsoft.AspNetCore.Mvc;
using Silver.Web.Services;
using Silver.Web.ViewModels;

namespace Silver.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var data = categoryService.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            ViewBag.categories = categoryService.GetDropDown();
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var res = categoryService.Create(model);
                if (res.Item1)
                {
                    return RedirectToAction("Index");
                }
            }
            ViewData["categories"] = categoryService.GetDropDown();
            ViewBag.categories = categoryService.GetDropDown();
            return View(model);
        }
    }
}