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
            Korisnik k = (Korisnik) LoginController.GetUlogovani(_context);
            ViewBag.Osoba = k;
            List<Bolest> b = _context.Bolest.Where(b => b.CovidKartonID == k.CovidKartonID).ToList();
            Tuple<CovidKarton, Korisnik, IEnumerable<Bolest>> tuple = new Tuple<CovidKarton, Korisnik, IEnumerable<Bolest>>(_context.CovidKarton.Find(k.CovidKartonID), k, b);
            return View(tuple);
        }

        public async Task<IActionResult> TestiranjaNaCovid()
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
            Korisnik k = (Korisnik)LoginController.GetUlogovani(_context);
            List<CovidTest> covidTestovi = _context.CovidTest.Where(cT => cT.CovidKartonID == k.CovidKartonID).ToList();
            List<CovidTest> prethodniTestovi = covidTestovi.Where(test => test.DatumTestiranja.CompareTo(DateTime.Now) < 0).ToList();
            List<CovidTest> zakazaniTestovi = covidTestovi.Where(test => test.DatumTestiranja.CompareTo(DateTime.Now) >= 0).ToList();
            return View(new Tuple<List<CovidTest>, List<CovidTest>>(prethodniTestovi, zakazaniTestovi));
        }

        public async Task<IActionResult> Vakcinacija()
        {
            Osoba o = LoginController.GetUlogovani(_context);
            ViewBag.Osoba = o;
            Korisnik k = (Korisnik)LoginController.GetUlogovani(_context);
            CovidKarton cK = _context.CovidKarton.Where(c => c.ID == k.CovidKartonID).First();
            Vakcinacija v = _context.Vakcinacija.Find(cK.VakcinacijaID);
            if(v != null)
            {
                Doza prvaDoza = _context.Doza.Find(v.PrvaDozaID);
                Doza drugaDoza = _context.Doza.Find(v.DrugaDozaID);
                Tuple<Korisnik, Vakcinacija, Doza, Doza, bool> tuple = new Tuple<Korisnik, Vakcinacija, Doza, Doza, bool>(k, v, prvaDoza, drugaDoza, true);
                return View(tuple);
            }
            else
            {
                bool z = _context.ZahtjevZaVakcinaciju.Where(zH => zH.KorisnikID == k.ID).Any();
                return View(new Tuple<Korisnik, Vakcinacija, Doza, Doza, bool>(k, null, null, null, z));
                //if (z == null)
                //    return View(new Tuple<Korisnik, Vakcinacija, Doza, Doza, bool>(k, null, null, null, false));
                //else return View(new Tuple<Korisnik, Vakcinacija, Doza, Doza, bool>(k, null, null, null, true));
            }
        }
    }
}
