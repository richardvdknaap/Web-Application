﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Foto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Link { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }

}
