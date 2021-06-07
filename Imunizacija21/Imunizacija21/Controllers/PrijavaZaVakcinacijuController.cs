﻿using System;
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
    public class PrijavaZaVakcinacijuController : Controller
    {
        private readonly DataContext _context;

        public PrijavaZaVakcinacijuController(DataContext context)
        {
            _context = context;
        }

        // GET: PrijavaZaVakcinaciju
        public async Task<IActionResult> Index()
        {
            return View(await _context.ZahtjevZaVakcinaciju.ToListAsync());
        }

        // GET: PrijavaZaVakcinaciju/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaVakcinaciju = await _context.ZahtjevZaVakcinaciju
                .FirstOrDefaultAsync(m => m.ID == id);
            if (zahtjevZaVakcinaciju == null)
            {
                return NotFound();
            }

            return View(zahtjevZaVakcinaciju);
        }

        // GET: PrijavaZaVakcinaciju/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PrijavaZaVakcinaciju/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,OdobrenZahtjev")] ZahtjevZaVakcinaciju zahtjevZaVakcinaciju)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zahtjevZaVakcinaciju);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zahtjevZaVakcinaciju);
        }

        // GET: PrijavaZaVakcinaciju/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaVakcinaciju = await _context.ZahtjevZaVakcinaciju.FindAsync(id);
            if (zahtjevZaVakcinaciju == null)
            {
                return NotFound();
            }
            return View(zahtjevZaVakcinaciju);
        }

        // POST: PrijavaZaVakcinaciju/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,OdobrenZahtjev")] ZahtjevZaVakcinaciju zahtjevZaVakcinaciju)
        {
            if (id != zahtjevZaVakcinaciju.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zahtjevZaVakcinaciju);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZahtjevZaVakcinacijuExists(zahtjevZaVakcinaciju.ID))
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
            return View(zahtjevZaVakcinaciju);
        }

        // GET: PrijavaZaVakcinaciju/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaVakcinaciju = await _context.ZahtjevZaVakcinaciju
                .FirstOrDefaultAsync(m => m.ID == id);
            if (zahtjevZaVakcinaciju == null)
            {
                return NotFound();
            }

            return View(zahtjevZaVakcinaciju);
        }

        // POST: PrijavaZaVakcinaciju/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zahtjevZaVakcinaciju = await _context.ZahtjevZaVakcinaciju.FindAsync(id);
            _context.ZahtjevZaVakcinaciju.Remove(zahtjevZaVakcinaciju);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZahtjevZaVakcinacijuExists(int id)
        {
            return _context.ZahtjevZaVakcinaciju.Any(e => e.ID == id);
        }
    }
}