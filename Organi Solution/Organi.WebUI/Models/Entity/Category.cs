using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Organi.WebUI.Models.Entity
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsFeaturedFilter { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
