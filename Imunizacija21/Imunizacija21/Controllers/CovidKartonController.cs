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
    public class CovidKartonController : Controller
    {
        private readonly DataContext _context;

        public CovidKartonController(DataContext context)
        {
            _context = context;
        }

        // GET: CovidKarton
        public async Task<IActionResult> Index()
        {
            return View(await _context.CovidKarton.ToListAsync());
        }

        // GET: CovidKarton/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var covidKarton = await _context.CovidKarton
                .FirstOrDefaultAsync(m => m.ID == id);
            if (covidKarton == null)
            {
                return NotFound();
            }

            return View(covidKarton);
        }

        // GET: CovidKarton/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CovidKarton/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,VakcinacijaID")] CovidKarton covidKarton)
        {
            if (ModelState.IsValid)
            {
                _context.Add(covidKarton);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(covidKarton);
        }

        // GET: CovidKarton/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var covidKarton = await _context.CovidKarton.FindAsync(id);
            if (covidKarton == null)
            {
                return NotFound();
            }
            return View(covidKarton);
        }

        // POST: CovidKarton/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,VakcinacijaID")] CovidKarton covidKarton)
        {
            if (id != covidKarton.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(covidKarton);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CovidKartonExists(covidKarton.ID))
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
            return View(covidKarton);
        }

        // GET: CovidKarton/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var covidKarton = await _context.CovidKarton
                .FirstOrDefaultAsync(m => m.ID == id);
            if (covidKarton == null)
            {
                return NotFound();
            }

            return View(covidKarton);
        }

        // POST: CovidKarton/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var covidKarton = await _context.CovidKarton.FindAsync(id);
            _context.CovidKarton.Remove(covidKarton);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CovidKartonExists(int id)
        {
            return _context.CovidKarton.Any(e => e.ID == id);
        }
    }
}
