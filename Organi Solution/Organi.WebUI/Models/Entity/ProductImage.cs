using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organi.WebUI.Models.Entity
{
    public class ProductImage
    {
        public int Id { get; set; }

        public string Path { get; set; }

        public bool? IsMain { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
