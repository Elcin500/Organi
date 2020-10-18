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
    public class ShopController : Controller
    {
        readonly OrganiDbContext db;
        public ShopController(OrganiDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShopDetails(int id)
        {
            var viewModel = new ProductDetailViewModel();


            var product= db.Products.Include(p=>p.Images).Where(p => p.Id == id).FirstOrDefault();

            if (product==null)
            {
                return NotFound();
            }

            viewModel.Current = product;

            viewModel.RelatedProducts = db.Products.Include(p => p.Images)
                .Where(p => p.CategoryId == product.CategoryId && p.Id!=product.Id).ToList();


            return View(viewModel);
        }





        public IActionResult ShoppingCart()
        {
            return View();
        }
        public IActionResult CheckOut()
        {
            return View();
        }
    }
}
