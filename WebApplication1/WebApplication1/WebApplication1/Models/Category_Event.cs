using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Category_Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public Event Event { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Category Category { get; set; }

    }
}
