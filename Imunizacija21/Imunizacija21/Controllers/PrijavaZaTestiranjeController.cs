using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Imunizacija21.Data;
using Imunizacija21.Models;

namespace Imunizacija21.Controllers
{
    public class PrijavaZaTestiranjeController : Controller
    {
        private readonly DataContext _context;

        public PrijavaZaTestiranjeController(DataContext context)
        {
            _context = context;
        }

        // GET: PrijavaZaTestiranje
        public async Task<IActionResult> Index()
        {
            return View(await _context.ZahtjevZaTestiranje.ToListAsync());
        }

        // GET: PrijavaZaTestiranje/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaTestiranje = await _context.ZahtjevZaTestiranje
                .FirstOrDefaultAsync(m => m.ID == id);
            if (zahtjevZaTestiranje == null)
            {
                return NotFound();
            }

            return View(zahtjevZaTestiranje);
        }

        // GET: PrijavaZaTestiranje/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PrijavaZaTestiranje/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipCovidTesta,ID,OdobrenZahtjev")] ZahtjevZaTestiranje zahtjevZaTestiranje)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zahtjevZaTestiranje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zahtjevZaTestiranje);
        }

        // GET: PrijavaZaTestiranje/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaTestiranje = await _context.ZahtjevZaTestiranje.FindAsync(id);
            if (zahtjevZaTestiranje == null)
            {
                return NotFound();
            }
            return View(zahtjevZaTestiranje);
        }

        // POST: PrijavaZaTestiranje/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipCovidTesta,ID,OdobrenZahtjev")] ZahtjevZaTestiranje zahtjevZaTestiranje)
        {
            if (id != zahtjevZaTestiranje.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zahtjevZaTestiranje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZahtjevZaTestiranjeExists(zahtjevZaTestiranje.ID))
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
            return View(zahtjevZaTestiranje);
        }

        // GET: PrijavaZaTestiranje/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaTestiranje = await _context.ZahtjevZaTestiranje
                .FirstOrDefaultAsync(m => m.ID == id);
            if (zahtjevZaTestiranje == null)
            {
                return NotFound();
            }

            return View(zahtjevZaTestiranje);
        }

        // POST: PrijavaZaTestiranje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zahtjevZaTestiranje = await _context.ZahtjevZaTestiranje.FindAsync(id);
            _context.ZahtjevZaTestiranje.Remove(zahtjevZaTestiranje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZahtjevZaTestiranjeExists(int id)
        {
            return _context.ZahtjevZaTestiranje.Any(e => e.ID == id);
        }
    }
}
