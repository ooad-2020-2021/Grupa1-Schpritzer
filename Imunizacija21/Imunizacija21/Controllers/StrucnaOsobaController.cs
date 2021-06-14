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
    public class StrucnaOsobaController : Controller
    {
        private readonly DataContext _context;

        public StrucnaOsobaController(DataContext context)
        {
            _context = context;
        }

        // GET: StrucnaOsoba
        public async Task<IActionResult> Index()
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
            List<ZahtjevZaTestiranje> z = await _context.ZahtjevZaTestiranje.ToListAsync();
            //List<Tuple<ZahtjevZaTestiranje, Korisnik>> listaZiK = new List<Tuple<ZahtjevZaTestiranje, Korisnik>>();
            List<KorisnikZahtjev> listaZiK = new List<KorisnikZahtjev>();
            //Korisnik k = _context.Korisnik.Where(k => k.ID == _context.ZahtjevZaTestiranje.Where(z => z.))
            foreach (var item in z)
            {
                bool ima = _context.Korisnik.Where(k => k.ID == item.KorisnikID).Any();
                if (ima)
                {
                    Korisnik t = _context.Korisnik.Where(k => k.ID == item.KorisnikID).First();
                    listaZiK.Add(new KorisnikZahtjev(t.ID, t.Ime, t.Prezime, t.DatumRodjenja, t.Spol, t.JMBG, t.Email, t.BrojTelefona, t.LokalnaZdravstvenaUstanova, t.ZdravstvenaKartica,
                        t.Adresa, t.Zanimanje, item.ID, item.KorisnikID, item.DatumZahtjeva, item.OdobrenZahtjev, item.StrucnaOsobaID, item.CovidKartonID, item.Razlozi, item.Opis, item.TipCovidTesta, new DateTime(0), t.LokalnaZdravstvenaUstanova));
                }
            }
            return View(listaZiK);
            //return View(await _context.ZahtjevZaTestiranje.ToListAsync());
        }

        // GET: StrucnaOsoba/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
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

        // GET: StrucnaOsoba/Create
        public IActionResult Create()
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
            return View();
        }

        // POST: StrucnaOsoba/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Opis,TipCovidTesta,ID,DatumZahtjeva,OdobrenZahtjev,StrucnaOsobaID")] ZahtjevZaTestiranje zahtjevZaTestiranje)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
            if (ModelState.IsValid)
            {
                _context.Add(zahtjevZaTestiranje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zahtjevZaTestiranje);
        }

        // GET: StrucnaOsoba/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.ZahtjevZaTestiranje.FindAsync(id);
            var t = await _context.Korisnik.FindAsync(item.KorisnikID);
            KorisnikZahtjev korisnikZahtjev = new KorisnikZahtjev(t.ID, t.Ime, t.Prezime, t.DatumRodjenja, t.Spol, t.JMBG, t.Email, t.BrojTelefona, t.LokalnaZdravstvenaUstanova, t.ZdravstvenaKartica,
                    t.Adresa, t.Zanimanje, item.ID, item.KorisnikID, item.DatumZahtjeva, item.OdobrenZahtjev, item.StrucnaOsobaID, item.CovidKartonID, item.Razlozi, item.Opis, item.TipCovidTesta, DateTime.Now, t.LokalnaZdravstvenaUstanova);
            if (korisnikZahtjev == null)
            {
                return NotFound();
            }
            //Korisnik korisnik = _context.Korisnik.Where(k => k.ID == zahtjevZaTestiranje.KorisnikID).First();
            return View(korisnikZahtjev);
            //return View(zahtjevZaTestiranje);
        }

        // POST: StrucnaOsoba/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ZdravstvenaKartica,CovidKartonID,Adresa,Zanimanje,ID,Ime,Prezime,DatumRodjenja,Spol,JMBG,Email,BrojTelefona,LokalnaZdravstvenaUstanova,Razlozi,Opis,TipCovidTesta,IDZahtjeva,KorisnikID,DatumZahtjeva,OdobrenZahtjev,StrucnaOsobaID,CovidKartonID,ZakazaniDatum")] KorisnikZahtjev korisnikZahtjev)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
            if (id != korisnikZahtjev.ID)
            {
                return NotFound();
            }

            //KorisnikZahtjev korisnikKojiSeEdituje = korisnikZahtjev;

            //ZahtjevZaTestiranje zahtjevKojiSeEdituje = _context.ZahtjevZaTestiranje.Where(k => k.ID == zahtjevZaTestiranje.ID).First();
            //zahtjevKojiSeEdituje.DatumZahtjeva = zahtjevZaTestiranje.DatumZahtjeva;
            //zahtjevKojiSeEdituje.OdobrenZahtjev = zahtjevZaTestiranje.OdobrenZahtjev;
            //Korisnik korisnik = _context.Korisnik.Where(k => k.ID == zahtjevKojiSeEdituje.KorisnikID).First();

            ZahtjevZaTestiranje zahtjev = _context.ZahtjevZaTestiranje.Where(k => k.ID == korisnikZahtjev.IDZahtjeva).First();
            zahtjev.DatumZahtjeva = korisnikZahtjev.DatumZahtjeva;
            zahtjev.OdobrenZahtjev = korisnikZahtjev.OdobrenZahtjev;
            DateTime datumTesta = korisnikZahtjev.ZakazaniDatum;
            LokalnaZdravstvenaUstanova lokacija = korisnikZahtjev.Lokacija;
            int covidKartonID = korisnikZahtjev.CovidKartonID;

            if (ModelState.IsValid)
            {
                try
                {    
                    if (zahtjev.OdobrenZahtjev)
                    {
                        CovidTest test = new CovidTest(zahtjev.TipCovidTesta, datumTesta, lokacija, covidKartonID);
                        _context.Add(test);
                    }
                    _context.ZahtjevZaTestiranje.Remove(zahtjev);
                    await _context.SaveChangesAsync();
                    //_context.Update(zahtjev);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZahtjevZaTestiranjeExists(zahtjev.ID))
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
            //return View(zahtjevKojiSeEdituje);
            return View(zahtjev);
        }

        // GET: StrucnaOsoba/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
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

        // POST: StrucnaOsoba/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
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
