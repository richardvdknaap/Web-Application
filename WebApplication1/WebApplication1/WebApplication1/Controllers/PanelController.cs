using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    [Authorize]
    public class PanelController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}