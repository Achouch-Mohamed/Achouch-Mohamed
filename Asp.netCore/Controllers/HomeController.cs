using Asp.netCore.Data;
using Asp.netCore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;     
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hosting;
        public HomeController(ILogger<HomeController> logger , ApplicationDbContext db,IWebHostEnvironment hosting)
        {
            _logger = logger;
            _db = db;
            _hosting = hosting;
        }

        public IActionResult Index()        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Work()
        {
            IEnumerable<Work> obj = _db.works;
            return View(obj);
        }

        public IActionResult Creatework()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Creatework(WorkViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                Work employee = new Work
                {
                    Name = model.Name,
                    Description = model.Description,
                    Workimage = uniqueFileName,
                };
                _db.Add(employee);
                _db.SaveChanges();
                return RedirectToAction("Work");
            }
            return View();
        }
        private string UploadedFile(WorkViewModel model)
        {
            string uniqueFileName = null;

            if (model.Workimage != null)
            {
                string uploadsFolder = Path.Combine(_hosting.WebRootPath, "Uploads");
                uniqueFileName = /*Guid.NewGuid().ToString() + "_" +*/ model.Workimage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Workimage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SEndMsg()
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
