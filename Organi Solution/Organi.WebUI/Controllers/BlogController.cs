using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Organi.WebUI.Models.DataContext;

namespace Organi.WebUI.Controllers
{
    public class BlogController : Controller
    {
        readonly OrganiDbContext db;
        public BlogController(OrganiDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var posts = db.Posts.OrderByDescending(p=>p.Id).ToList();

            return View(posts);
        }
        public IActionResult BlogDetails(int id)
        {
            return View();
        }
    }
}
