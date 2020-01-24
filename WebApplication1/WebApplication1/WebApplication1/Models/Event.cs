using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Event
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public string Beschrijving { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        public string Info { get; set; }

        List<Foto> Fotos { get; set; }

    }
}
