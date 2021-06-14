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
    public class AdminStrucneOsobeController : Controller
    {
        private readonly DataContext _context;

        public AdminStrucneOsobeController(DataContext context)
        {
            _context = context;
        }

        // GET: AdminStrucneOsobe
        public async Task<IActionResult> Index()
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
            return View(await _context.StrucnaOsoba.ToListAsync());
        }

        // GET: AdminStrucneOsobe/Details/5
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

        // GET: AdminStrucneOsobe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminStrucneOsobe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Ime,Prezime,DatumRodjenja,Spol,JMBG,Email,BrojTelefona,LokalnaZdravstvenaUstanova,Ulogovan")] StrucnaOsoba strucnaOsoba)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
            if (ModelState.IsValid)
            {
                _context.Add(strucnaOsoba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(strucnaOsoba);
        }

        // GET: AdminStrucneOsobe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
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

        // POST: AdminStrucneOsobe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Ime,Prezime,DatumRodjenja,Spol,JMBG,Email,BrojTelefona,LokalnaZdravstvenaUstanova,Ulogovan")] StrucnaOsoba strucnaOsoba)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
            if (id != strucnaOsoba.ID)
            {
                return NotFound();
            }
            StrucnaOsoba strucnaKojaSeEdituje = _context.StrucnaOsoba.Where(k => k.ID == strucnaOsoba.ID).First();
            strucnaKojaSeEdituje.Ime = strucnaOsoba.Ime;
            strucnaKojaSeEdituje.Prezime = strucnaOsoba.Prezime;
            strucnaKojaSeEdituje.Spol = strucnaOsoba.Spol;
            strucnaKojaSeEdituje.JMBG = strucnaOsoba.JMBG;
            strucnaKojaSeEdituje.Email = strucnaOsoba.Email;
            strucnaKojaSeEdituje.BrojTelefona = strucnaOsoba.BrojTelefona;
            strucnaKojaSeEdituje.LokalnaZdravstvenaUstanova = strucnaOsoba.LokalnaZdravstvenaUstanova;
            
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(strucnaKojaSeEdituje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StrucnaOsobaExists(strucnaKojaSeEdituje.ID))
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
            return View(strucnaKojaSeEdituje);
        }

        // GET: AdminStrucneOsobe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
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

        // POST: AdminStrucneOsobe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
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
