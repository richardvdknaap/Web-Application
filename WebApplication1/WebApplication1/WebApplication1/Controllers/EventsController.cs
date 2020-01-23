using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Keukenhof.Controllers
{
    public class EventsController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }
    }
}