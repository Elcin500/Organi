using Organi.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organi.WebUI.Models.ViewModel
{
    public class ProductDetailViewModel
    {
        public Product Current { get; set; }

        public IEnumerable<Product> RelatedProducts { get; set; }
    }
}
