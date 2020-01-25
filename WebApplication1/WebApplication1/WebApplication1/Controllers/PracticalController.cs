using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PracticalController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }
    }
}