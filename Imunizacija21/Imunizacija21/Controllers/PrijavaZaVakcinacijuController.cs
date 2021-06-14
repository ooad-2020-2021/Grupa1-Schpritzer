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
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
            return View(await _context.ZahtjevZaVakcinaciju.ToListAsync());
        }

        // GET: PrijavaZaVakcinaciju/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
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
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
            Korisnik k = (Korisnik)LoginController.GetUlogovani(_context);
            List<Bolest> b = _context.Bolest.Where(b => b.CovidKartonID == k.CovidKartonID).ToList();
            Tuple<CovidKarton, Korisnik, IEnumerable<Bolest>> tuple = new Tuple<CovidKarton, Korisnik, IEnumerable<Bolest>>(_context.CovidKarton.Find(k.CovidKartonID), k, b);
            return View(tuple);
            //return View();
        }

        // POST: PrijavaZaVakcinaciju/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,DatumZahtjeva,OdobrenZahtjev,StrucnaOsobaID")] ZahtjevZaVakcinaciju zahtjevZaVakcinaciju)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
            if (ModelState.IsValid)
            {
                StrucnaOsoba strucnaOsoba = _context.StrucnaOsoba.First();
                strucnaOsoba.Zahtjevi.Add(zahtjevZaVakcinaciju);
                Korisnik korisnik = (Korisnik)LoginController.GetUlogovani(_context);
                zahtjevZaVakcinaciju.DatumZahtjeva = DateTime.Now;
                zahtjevZaVakcinaciju.KorisnikID = korisnik.ID;
                zahtjevZaVakcinaciju.StrucnaOsobaID = strucnaOsoba.ID;
                zahtjevZaVakcinaciju.CovidKartonID = korisnik.CovidKartonID;
                
                _context.Add(zahtjevZaVakcinaciju);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zahtjevZaVakcinaciju);
        }

        // GET: PrijavaZaVakcinaciju/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
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
        public async Task<IActionResult> Edit(int id, [Bind("ID,DatumZahtjeva,OdobrenZahtjev,StrucnaOsobaID")] ZahtjevZaVakcinaciju zahtjevZaVakcinaciju)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
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
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
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
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
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
