using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Keukenhof.Models;

namespace Keukenhof.Controllers
{
    public class AccessibilityController : Controller
    {
        // GET: HetPark
        public ActionResult Index()
        {
            return View();
        }
    }
}