using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Organi.WebUI.Models.Entity
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal price { get; set; }

        public string Unit { get; set; }
        public decimal Quantity { get; set; }
        public string ShortDescription { get; set; }

        public int CategoryId { get; set; }

        // [ForeignKey("CategoryId")] adlari eynidi diye lazim deil
        public virtual Category Category { get; set; }


        public ICollection<ProductImage> Images { get; set; }


        [NotMapped]
        public IFormFile[] file { get; set; }

        [NotMapped]
        public int fileSelectedIndex { get; set; }

    }
}
