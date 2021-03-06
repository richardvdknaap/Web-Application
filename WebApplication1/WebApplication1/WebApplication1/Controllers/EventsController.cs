﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    // Leest de evenementen uit de database en gebruikt deze voor de Events view.
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Events
        public async Task<IActionResult> Index()
        {
            return View(await _context.Events.ToListAsync());
        }

    }
}