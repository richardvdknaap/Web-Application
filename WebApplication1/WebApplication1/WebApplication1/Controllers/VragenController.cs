using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class VragenController : Controller
    {
        // GET: Vragen
        public ActionResult Index()
        {
            return View();
        }
    }
}