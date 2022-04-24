using Asp.netCore.Data;
using Asp.netCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asp.netCore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
                _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objects = _db.Category;
            return View(objects);
        }

        //Get Methode
        public IActionResult Create()
        {
            return View();
        }
        // Post Methode

        //public IActionResult Create(Category obj)
        //{
        //    _db.Category.Add(obj);
        //    _db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}
