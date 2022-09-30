using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Silver.Web.Services;
using Silver.Web.ViewModels;

namespace Silver.Web.Controllers
{
    [Authorize(Roles ="Admin")]
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
        public IActionResult Create(ProductViewModel model, IFormFile productPic)
        {
            if (ModelState.IsValid)
            {
                //upload the file
                var filename = "";
                if (productPic.Length > 0)
                {
                    filename = "/Uploads/Products/" + Guid.NewGuid().ToString() + Path.GetExtension(productPic.FileName);
                    var filepath = Directory.GetCurrentDirectory() + "/wwwroot" + filename;
                    using (var stream = new FileStream(filepath, FileMode.Create))
                    {
                        productPic.CopyTo(stream);
                    }
                }
                //create the product in db
                model.FilePath = filename;
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