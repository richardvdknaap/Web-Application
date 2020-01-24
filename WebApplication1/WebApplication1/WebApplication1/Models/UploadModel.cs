using Microsoft.AspNetCore.Http;

namespace WebApplication1.Models
{
    public class UploadModel
    {
        public IFormFile File { set; get; }
    }
}
