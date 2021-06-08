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
    public class ProfilChangeController : Controller
    {
        private readonly DataContext _context;

        static CovidKarton covidKarton = new CovidKarton();
        static Korisnik user = new Korisnik("Bogić", "Bogičević", "M", "1904952170031", "bogic.bogicevic@gmail.com", new List<string>() { "061123456" }, LokalnaZdravstvenaUstanova.VRAZOVA, "1A2B3C4D", covidKarton, "Zmaja od Bosne 23", Zanimanje.PENZIONER);

        public ProfilChangeController(DataContext context)
        {
            _context = context;
            /*_context.Add(user);
            _context.SaveChangesAsync();*/
        }

        // GET: ProfilChange
        public async Task<IActionResult> Index()
        {
            return View(await _context.Osoba.ToListAsync());
        }

        // GET: ProfilChange/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var osoba = await _context.Osoba.FindAsync(id);
            if (osoba == null)
            {
                return NotFound();
            }
            return View(osoba);
        }

        // POST: ProfilChange/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,DatumRodjenja,Email")] Osoba osoba)
        {
            if (id != osoba.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(osoba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OsobaExists(osoba.ID))
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
            return View(osoba);
        }

        private bool OsobaExists(int id)
        {
            return _context.Osoba.Any(e => e.ID == id);
        }
    }
}
