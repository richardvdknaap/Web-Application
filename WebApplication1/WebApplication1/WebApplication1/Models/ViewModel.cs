using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ViewModel
    {
        public List<Category> AllCats { get; set; }

        public Event Event { get; set; }
        public Foto Foto { get; set; }
        public UploadModel UploadModel {get;set;}
        public Category Category { get; set; }
        public Category_Event Category_Event { get; set; }
 
    }
}
