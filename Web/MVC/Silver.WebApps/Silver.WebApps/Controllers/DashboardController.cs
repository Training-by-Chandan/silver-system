using Microsoft.AspNetCore.Mvc;

namespace Silver.WebApps.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UseDifferentPage(int num)
        {
            switch (num)
            {
                case 1:
                    return View("Index");

                case 2:
                    return RedirectToAction("Index");

                default:
                    return View();
            }
        }
    }
}