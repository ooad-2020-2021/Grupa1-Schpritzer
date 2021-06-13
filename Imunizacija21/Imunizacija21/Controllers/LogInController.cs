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
    public class LoginController : Controller
    {
        private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;
        }

        public static Korisnik GetUlogovani(DataContext context)
        {
            return context.Korisnik.Where(k => k.Ulogovan == true).First();
        }

        // GET: LogIn
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Login(string JMBG, string brZK)
        {
            //int i = 0;
            //treba naci korisnika i stavit mu ulogovan = true
            Korisnik korisnik = _context.Korisnik.Where(k => k.JMBG == JMBG).First();
            if (korisnik.ZdravstvenaKartica == brZK)
            {
                korisnik.Ulogovan = true;
                _context.Update(korisnik);
                await _context.SaveChangesAsync();
            }               
            //else
                //error ispisati
            //return RedirectToAction(nameof(ProfileChangeController.Index));
            return RedirectToAction("Index", "CovidKarton");
        }

        public async Task<IActionResult> LogOut()
        {
            Korisnik korisnik = GetUlogovani(_context);
            korisnik.Ulogovan = false;
            _context.Update(korisnik);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        //// GET: LogIn/Details/5
        //public async Task<IActionResult> Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var logIn = await _context.LogIn
        //        .FirstOrDefaultAsync(m => m.JMBG == id);
        //    if (logIn == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(logIn);
        //}

        //// GET: LogIn/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: LogIn/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("JMBG")] LogIn logIn)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(logIn);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(logIn);
        //}

        //// GET: LogIn/Edit/5
        //public async Task<IActionResult> Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var logIn = await _context.LogIn.FindAsync(id);
        //    if (logIn == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(logIn);
        //}

        //// POST: LogIn/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(string id, [Bind("JMBG")] LogIn logIn)
        //{
        //    if (id != logIn.JMBG)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(logIn);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!LogInExists(logIn.JMBG))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(logIn);
        //}

        //// GET: LogIn/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var logIn = await _context.LogIn
        //        .FirstOrDefaultAsync(m => m.JMBG == id);
        //    if (logIn == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(logIn);
        //}

        //// POST: LogIn/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var logIn = await _context.LogIn.FindAsync(id);
        //    _context.LogIn.Remove(logIn);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool LogInExists(string id)
        //{
        //    return _context.LogIn.Any(e => e.JMBG == id);
        //}
    }
}
