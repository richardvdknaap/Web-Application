using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Category_Event
    {
        [Key]
        public string EventName { get; set; }
        public Event Event { get; set; }
        [Key]
        public string CategoryName { get; set; }
        public Category Category { get; set; }

    }
}
