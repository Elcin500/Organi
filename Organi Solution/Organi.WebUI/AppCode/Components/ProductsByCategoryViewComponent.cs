using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Organi.WebUI.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organi.WebUI.AppCode.Components
{
    public class ProductsByCategoryViewComponent : ViewComponent
    {
        readonly OrganiDbContext db;

        public ProductsByCategoryViewComponent(OrganiDbContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke(string title,int val=1) 
        {
            ViewBag.ProductsTitle = title;

            var query = db.Products
                .Include(p=>p.Images)
                .AsQueryable();

            switch (val)
            {
                case 1:
                    query = query.OrderByDescending(p => p.Id);
                    break;
                case 2:
                    query = query.OrderByDescending(p => p.price);
                    break;
                case 3:
                    query = query.OrderBy(p => p.price);
                    break;
                default:
                    break;
            }

            var products = query.Take(3).ToList();


            return View(products);
        }
    }
}
