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
    public class ProfileChangeController : Controller
    {
        private readonly DataContext _context;

        //static CovidKarton karton = new CovidKarton();
        //static Korisnik user = new Korisnik("Bogic", "Bogicevic", "M", "1503953172311", "bogic.bogicevic@gmail.com", "061123456", LokalnaZdravstvenaUstanova.VRAZOVA, "1A2B3C4D", karton.ID, "Zmaja od Bosne 11", Zanimanje.PENZIONER);
        //static Korisnik user = new Korisnik("Bogic", "Bogicevic", "M", "1503953172311", "bogic.bogicevic@gmail.com", "061123456", LokalnaZdravstvenaUstanova.VRAZOVA, "1A2B3C4D", karton.ID, "Zmaja od Bosne 11", Zanimanje.PENZIONER);

        //static Korisnik user2 = new Korisnik("Mujo", "Mujic", "M", "1302964172076", "mujo1.mujic@gmail.com", "033492674", LokalnaZdravstvenaUstanova.ILIJAS, "P32I71BM", karton.ID, "Kamenice 154", Zanimanje.NEZAPOSLEN);
        //static Korisnik user3 = new Korisnik("Selma", "Selimovic", "Z", "0512978170351", "selma.selimovic@hotmail.com", "0603237194", LokalnaZdravstvenaUstanova.SARAJ_POLJE, "73A4GT3Z", karton.ID, "Olimpijska 15", Zanimanje.PROSVJETNI_RADNIK);
        //static Korisnik user4 = new Korisnik("Ivan", "Ivanovic", "M", "1503953172311", "ivanivanovic@yahoo.com", "065313635", LokalnaZdravstvenaUstanova.ILIDZA, "3L55FG18", karton.ID, "Stupska 23", Zanimanje.POLICAJAC);
        //static Korisnik user5 = new Korisnik("Ena", "Begovic", "Z", "2107002170017", "ena.harrystyles@gmail.com", "062034120", LokalnaZdravstvenaUstanova.OMER_MASLIC, "S93U74G1", karton.ID, "Gradacacka 43", Zanimanje.UCENIK);
        //static Korisnik user6 = new Korisnik("Dalila", "Tomic", "Z", "0309948172311", "tomic.dalila@gmail.com", "062356757", LokalnaZdravstvenaUstanova.HADZICI, "B3FGT467", karton.ID, "Zunovacka 131", Zanimanje.UGOSTITELJ);
        //static Korisnik user7 = new Korisnik("Asim", "Atic", "M", "1802985172341", "asim.atic@gmail.com", "061999888", LokalnaZdravstvenaUstanova.VRAZOVA, "E4A576F1", karton.ID, "Mis Irbina 2", Zanimanje.TRGOVAC);
        //static Korisnik user8 = new Korisnik("Jelena", "Micic", "Z", "2705992174400", "jelena.micic@yahoo.com", "063654122", LokalnaZdravstvenaUstanova.OTOKA, "7EF86A5D", karton.ID, "Kasima Hadzica 5", Zanimanje.PROSVJETNI_RADNIK);
        //static Korisnik user9 = new Korisnik("Lamija", "Tanovic", "Z", "2508000173500", "lamija.tanovic@hotmail.com", "062333232", LokalnaZdravstvenaUstanova.STARI_GRAD, "2FA23C7D", karton.ID, "Logavina 9", Zanimanje.STUDENT);
        //static Korisnik user10 = new Korisnik("Anur", "Mesic", "M", "1212973172222", "anur.mesic@gmail.com", "061175641", LokalnaZdravstvenaUstanova.OMER_MASLIC, "8ETB6R2D", karton.ID, "Ferde Hauptmana 17", Zanimanje.MEDICINSKI_RADNIK);
        //static Korisnik user11 = new Korisnik("Aldina", "Basic", "Z", "0609980175213", "aldina.basic@gmail.com", "033727111", LokalnaZdravstvenaUstanova.VOGOSCA, "TR321G7D", karton.ID, "Skendera Kulenovića 3", Zanimanje.PRIVREDNIK);



        //static StrucnaOsoba strucna1 = new StrucnaOsoba("Benjamin", "Pasic", "M", "2402000174242", "benjamin.pasic@gmail.com", "061543543", LokalnaZdravstvenaUstanova.VRAZOVA);
        //static StrucnaOsoba strucna2 = new StrucnaOsoba("Eldar", "Civgin", "M", "2606000176653", "eldar.civgin@gmail.com", "061345345", LokalnaZdravstvenaUstanova.SARAJ_POLJE);
        //static StrucnaOsoba strucna3 = new StrucnaOsoba("Muhamed", "Borovac", "M", "0702000175242", "muhamed.borovac@gmail.com", "062474747", LokalnaZdravstvenaUstanova.STARI_GRAD);
        //static StrucnaOsoba strucna4 = new StrucnaOsoba("Dzenan", "Nuhic", "M", "1206000173777", "dzenan.nuhic@gmail.com", "062145415", LokalnaZdravstvenaUstanova.OMER_MASLIC);

        public ProfileChangeController(DataContext context)
        {
            _context = context;
            //_context.Add(user);
            //_context.Add(user2);
            //_context.Add(user3);
            //_context.Add(user4);
            //_context.Add(user5);
            //_context.Add(user6);
            //_context.Add(user7);
            //_context.Add(user8);
            //_context.Add(user9);
            //_context.Add(user10);
            //_context.Add(user11);
            //_context.Add(strucna1);
            //_context.Add(strucna2);
            //_context.Add(strucna3);
            //_context.Add(strucna4);
            //_context.SaveChangesAsync();
        }

        // GET: ProfileChange
        public async Task<IActionResult> Index()
        {
            return View(await _context.Korisnik.ToListAsync());
        }

        // GET: ProfileChange/Details/5
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

        // GET: ProfileChange/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProfileChange/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ZdravstvenaKartica,CovidKartonID,Adresa,Zanimanje,ID,Ime,Prezime,DatumRodjenja,Spol,JMBG,Email,BrojTelefona,LokalnaZdravstvenaUstanova")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(korisnik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(korisnik);
        }

        // GET: ProfileChange/Edit/5
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

        // POST: ProfileChange/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ZdravstvenaKartica,CovidKartonID,Adresa,Zanimanje,ID,Ime,Prezime,DatumRodjenja,Spol,JMBG,Email,BrojTelefona,LokalnaZdravstvenaUstanova")] Korisnik korisnik)
        {
            if (id != korisnik.ID)
            {
                return NotFound();
            }

            Korisnik korisnikKojiSeEdituje = _context.Korisnik.Where(k => k.ID == korisnik.ID).First();
            korisnikKojiSeEdituje.Adresa = korisnik.Adresa;
            korisnikKojiSeEdituje.LokalnaZdravstvenaUstanova = korisnik.LokalnaZdravstvenaUstanova;
            korisnikKojiSeEdituje.BrojTelefona = korisnik.BrojTelefona;
            korisnikKojiSeEdituje.Email = korisnik.Email;
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

        // GET: ProfileChange/Delete/5
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

        // POST: ProfileChange/Delete/5
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
