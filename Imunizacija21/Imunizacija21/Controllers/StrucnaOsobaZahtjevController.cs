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
    public class StrucnaOsobaZahtjevController : Controller
    {
        private readonly DataContext _context;

        public StrucnaOsobaZahtjevController(DataContext context)
        {
            _context = context;
        }

        // GET: StrucnaOsobaZahtjev
        public async Task<IActionResult> Index()
        {
            return View(await _context.StrucnaOsoba.ToListAsync());
        }

        // GET: StrucnaOsobaZahtjev/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var strucnaOsoba = await _context.StrucnaOsoba
                .FirstOrDefaultAsync(m => m.ID == id);
            if (strucnaOsoba == null)
            {
                return NotFound();
            }

            return View(strucnaOsoba);
        }

        // GET: StrucnaOsobaZahtjev/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StrucnaOsobaZahtjev/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,DatumRodjenja,Email")] StrucnaOsoba strucnaOsoba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(strucnaOsoba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(strucnaOsoba);
        }

        // GET: StrucnaOsobaZahtjev/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var strucnaOsoba = await _context.StrucnaOsoba.FindAsync(id);
            if (strucnaOsoba == null)
            {
                return NotFound();
            }
            return View(strucnaOsoba);
        }

        // POST: StrucnaOsobaZahtjev/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,DatumRodjenja,Email")] StrucnaOsoba strucnaOsoba)
        {
            if (id != strucnaOsoba.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(strucnaOsoba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StrucnaOsobaExists(strucnaOsoba.ID))
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
            return View(strucnaOsoba);
        }

        // GET: StrucnaOsobaZahtjev/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var strucnaOsoba = await _context.StrucnaOsoba
                .FirstOrDefaultAsync(m => m.ID == id);
            if (strucnaOsoba == null)
            {
                return NotFound();
            }

            return View(strucnaOsoba);
        }

        // POST: StrucnaOsobaZahtjev/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var strucnaOsoba = await _context.StrucnaOsoba.FindAsync(id);
            _context.StrucnaOsoba.Remove(strucnaOsoba);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StrucnaOsobaExists(int id)
        {
            return _context.StrucnaOsoba.Any(e => e.ID == id);
        }
    }
}
