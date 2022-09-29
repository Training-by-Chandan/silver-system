using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            Response.Cookies.Append("class", "ASP.NET", new CookieOptions() { Expires=DateTime.Now.AddSeconds(20), Path="/category" });

            return View();
        }

        public IActionResult AddToSession(int id)
        {
            var cartStr = HttpContext.Session.GetString("cart");
            var cartModel = new List<SessionViewModel>();
            var product = productService.GetProductbyId(id);
            if (!string.IsNullOrWhiteSpace(cartStr))
            {

                cartModel = JsonConvert.DeserializeObject<List<SessionViewModel>>(cartStr);
                var existing = cartModel.FirstOrDefault(p => p.Id == id);
                if (existing==null)
                {
                    cartModel.Add(new SessionViewModel()
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Price = product.Price,
                        Quantity = 1,
                        Unit = product.Units,
                    });
                }
                else
                {
                    existing.Quantity++;
                }
            }
            else
            {
                cartModel.Add(new SessionViewModel()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = 1,
                    Unit = product.Units,
                });
            }

            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cartModel));
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}