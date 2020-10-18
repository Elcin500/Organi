using Organi.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organi.WebUI.Models.ViewModel
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; }

        public List<Product> FeaturedProducts { get; set; }


    }
}
