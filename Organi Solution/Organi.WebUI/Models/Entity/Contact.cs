﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Organi.WebUI.Models.Entity
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email Doldurulmalidir")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }

        public string Answer { get; set; }

        public DateTime? AnswerDate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }

    }
}
