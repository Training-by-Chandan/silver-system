using Microsoft.AspNetCore.Mvc;
using Silver.WebApps.Data;
using Silver.WebApps.Models;

namespace Silver.WebApps.Controllers
{
    public class StudentNewController : Controller
    {
        private readonly ApplicationDbContext db;

        public StudentNewController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = db.Students.Find(id);
            return View(data);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var data = db.Students.Find(id);
            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = db.Students.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Student model)
        {
            if (ModelState.IsValid)
            {
                db.Students.Update(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Student model)
        {
            var existing = db.Students.Find(model.Id);
            db.Students.Remove(existing);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}