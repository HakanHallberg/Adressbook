using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Adressbook.Data;
using Adressbook.Models;
using Microsoft.Extensions.Logging;

namespace Adressbook.Controllers
{
    public class AdressesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<AdressesController> _logger;

        public AdressesController(ApplicationDbContext context, ILogger<AdressesController>logger)
        {
            _logger = logger;
            _context = context;
        }

        // GET: Adresses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Adresses.ToListAsync());
        }

        // GET: Adresses
        public async Task<IActionResult> PersonBy(int id)
        {
            return View("Index", await _context.Adresses.Where(a => a.PersonID == id).ToListAsync());
        }
        // GET: Adresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adress = await _context.Adresses
                .SingleOrDefaultAsync(m => m.AdressID == id);
            if (adress == null)
            {
                _logger.LogWarning("Could not find adress =" + id.ToString());
                return NotFound();
            }

            return View(adress);
        }

        // GET: Adresses/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateByPerson(int id)
        {
            Adress newAdress = new Adress { PersonID = id };
            return View("Create", newAdress);
        }

        // POST: Adresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdressID,AdressName,PersonID")] Adress adress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CreateByPerson), new { id = adress.PersonID});
            }
            return View(adress);
        }

        // GET: Adresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adress = await _context.Adresses.SingleOrDefaultAsync(m => m.AdressID == id);
            if (adress == null)
            {
                return NotFound();
            }
            return View(adress);
        }

        // POST: Adresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdressID,AdressName")] Adress adress)
        {
            if (id != adress.AdressID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdressExists(adress.AdressID))
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
            return View(adress);
        }

        // GET: Adresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adress = await _context.Adresses
                .SingleOrDefaultAsync(m => m.AdressID == id);
            if (adress == null)
            {
                return NotFound();
            }

            return View(adress);
        }

        // POST: Adresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adress = await _context.Adresses.SingleOrDefaultAsync(m => m.AdressID == id);
            _context.Adresses.Remove(adress);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdressExists(int id)
        {
            return _context.Adresses.Any(e => e.AdressID == id);
        }
    }
}
