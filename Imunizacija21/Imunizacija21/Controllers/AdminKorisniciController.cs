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
    public class AdminKorisniciController : Controller
    {
        private readonly DataContext _context;        

        public AdminKorisniciController(DataContext context)
        {
            _context = context;
            /*_context.Add(strucna1);
            _context.SaveChangesAsync();*/
        }

        // GET: AdminKorisnici
        public async Task<IActionResult> Index()
        {
            return View(await _context.Korisnik.ToListAsync());
        }

        // GET: AdminKorisnici/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnik = await _context.Korisnik
                .FirstOrDefaultAsync(m => m.ID == id);
            if (korisnik == null)
            {
                return NotFound();
            }

            return View(korisnik);
        }

        // GET: AdminKorisnici/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminKorisnici/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ZdravstvenaKartica,CovidKartonID,Adresa,Zanimanje,ID,Ime,Prezime,DatumRodjenja,Spol,JMBG,Email,BrojTelefona,LokalnaZdravstvenaUstanova,Ulogovan")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(korisnik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(korisnik);
        }

        // GET: AdminKorisnici/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnik = await _context.Korisnik.FindAsync(id);
            if (korisnik == null)
            {
                return NotFound();
            }
            return View(korisnik);
        }

        // POST: AdminKorisnici/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ZdravstvenaKartica,CovidKartonID,Adresa,Zanimanje,ID,Ime,Prezime,DatumRodjenja,Spol,JMBG,Email,BrojTelefona,LokalnaZdravstvenaUstanova,Ulogovan")] Korisnik korisnik)
        {
            if (id != korisnik.ID)
            {
                return NotFound();
            }
            Korisnik korisnikKojiSeEdituje = _context.Korisnik.Where(k => k.ID == korisnik.ID).First();
            korisnikKojiSeEdituje.Ime = korisnik.Ime;
            korisnikKojiSeEdituje.Prezime = korisnik.Prezime;
            korisnikKojiSeEdituje.Spol = korisnik.Spol;
            korisnikKojiSeEdituje.JMBG = korisnik.JMBG;
            korisnikKojiSeEdituje.Email = korisnik.Email;
            korisnikKojiSeEdituje.BrojTelefona = korisnik.BrojTelefona;
            korisnikKojiSeEdituje.LokalnaZdravstvenaUstanova = korisnik.LokalnaZdravstvenaUstanova;
            korisnikKojiSeEdituje.ZdravstvenaKartica = korisnik.ZdravstvenaKartica;
            korisnikKojiSeEdituje.CovidKartonID = korisnik.CovidKartonID;
            korisnikKojiSeEdituje.Adresa = korisnik.Adresa;
            korisnikKojiSeEdituje.Zanimanje = korisnik.Zanimanje;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(korisnikKojiSeEdituje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KorisnikExists(korisnikKojiSeEdituje.ID))
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
            return View(korisnikKojiSeEdituje);
        }

        // GET: AdminKorisnici/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnik = await _context.Korisnik
                .FirstOrDefaultAsync(m => m.ID == id);
            if (korisnik == null)
            {
                return NotFound();
            }

            return View(korisnik);
        }

        // POST: AdminKorisnici/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var korisnik = await _context.Korisnik.FindAsync(id);
            _context.Korisnik.Remove(korisnik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KorisnikExists(int id)
        {
            return _context.Korisnik.Any(e => e.ID == id);
        }
    }
}
