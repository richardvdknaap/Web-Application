using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public string Beschrijving { get; set; }

        [Required]
        public List<Category_Event> Category_Event { get; set; }
    }
}
