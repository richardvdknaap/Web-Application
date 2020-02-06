using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    // Controleerd de login van de user
    [Authorize]
    public class PanelController : Controller
    {
        // Leest de DbContext en de HostingEnvironment
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public PanelController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            hostingEnvironment = environment;
        }


        // GET: DBEvents
        public async Task<IActionResult> Index()
        {
            //wacht op resultaat van context.Events.ToListAsync
            return View(await _context.Events.ToListAsync());
        }


        // GET: DBEvents/Details/5
        //id begint als NULL om te controleren of er wel Details zijn
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: DBEvents/Create
        // Laat de Create knop functioneren
        public IActionResult Create()
        {
            //List<Category> categories = await _context.Category.ToListAsync();
            ViewModel mymodel = new ViewModel() { Event = null, Foto = null, UploadModel = null };
            return View(mymodel);
        }

        // Als create wordt geselecteerd word de juiste view gestuurd
        public IActionResult CreateCat()
        {
            return View();
        }

        // POST: DBEvents/Create
        //Maakt event aan
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,Beschrijving,Datum,Info")] Event @event, [Bind("Id,Link,EventId")] Foto @foto)
        {
            if (ModelState.IsValid)
            {

                _context.Add(@event);
                @foto.EventId = @event.Id;
                _context.Add(@foto);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            ViewModel mymodel = new ViewModel() { Event = @event, Foto = @foto};
            return View(mymodel);
        }

        // GET: DBEvents/Edit/5
        // Laat de Edit knop functioneren
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: DBEvents/Edit/5
        //Veranderd Event
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Beschrijving,Datum,Info")] Event @event)
        {
            if (id != @event.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                //Controleerd of opgegeven ID bestaat
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: DBEvents/Delete/5
        // Laat de Delete knop functioneren
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: DBEvents/Delete/5
        // Verwijderd Event
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @event = await _context.Events.FindAsync(id);
            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // controlereerd of er een event bestaat
        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}
