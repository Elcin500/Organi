using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Organi.WebUI.Models.DataContext;
using Organi.WebUI.Models.Entity;
using Organi.WebUI.Models.ViewModel;

namespace Organi.WebUI.Controllers
{
    public class HomeController : Controller
    {
        readonly OrganiDbContext db;
        public HomeController(OrganiDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var model = new HomeViewModel();

            model.Categories = db.Categories
               .Where(c => c.IsFeaturedFilter == true)
               .ToList();

               model.FeaturedProducts = db.Products
                .Include(p => p.Category)
                .Include(p => p.Images)
                .Where(p => p.Category.IsFeaturedFilter == true)
                .ToList();



            return View(model);
        }
        public IActionResult Contact()
        {
            ViewBag.AppInfo = db.AppInfos.FirstOrDefault();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(Contact contact)
        {
            ViewBag.AppInfo = db.AppInfos.FirstOrDefault();

            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();

                ModelState.Clear();
                ViewBag.Message = "Sorgunuz Gonderildi";
            }
            return View();
        }

        public IActionResult ContactQuestions()
        {
            var questions= db.Contacts.ToList();

            return View(questions);
        }

        public IActionResult Subscribe(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return Json(new
                {
                    error = true,
                    message = "Email doldurulmayib"
                });
            }
            else if (db.Subscribes.Any(s=>s.Email==email))
            {
                return Json(new
                {
                    error = true,
                    message = "Artiq Abonesiniz"
                });
            }
            else
            {
                var subscribe = new Subscribe
                {
                    Email = email
                };

                db.Subscribes.Add(subscribe);
                db.SaveChanges();
                return Json(new
                {
                    error = false,
                    message = "Abune oldunuz"
                });
            }
        }
    }
}
