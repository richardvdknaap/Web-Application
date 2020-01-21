using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Keukenhof_2._0.Models
{
    public class Foto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Link { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }

    }
}
