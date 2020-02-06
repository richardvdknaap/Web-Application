using Microsoft.AspNetCore.Http;

namespace WebApplication1.Models
{
    public class UploadModel
    {

        //Voor het uploaden van een foto (werkt helaas nog niet)
        public IFormFile File { set; get; }
    }
}
