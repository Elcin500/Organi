using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Organi.WebUI.Models.Entity
{
    public class Subscribe
    {
        public int Id { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
