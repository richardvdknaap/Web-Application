﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Keukenhof_2._0.Models;

namespace Keukenhof.Controllers
{
    public class HetParkController : Controller
    {
        // GET: HetPark
        public ActionResult Index()
        {
            return View();
        }
    }
}