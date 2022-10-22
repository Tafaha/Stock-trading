using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stock_trading.Models;
using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Stock_trading.Controllers
{
    public class AksjeController : Controller
    {
        private readonly ApplicationDbContext _db;
        //Konstruktør
        public AksjeController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET
        public async Task<IActionResult> Index()
        {
            return View(await _db.Aksje.ToListAsync());  //Lister ut aksjene
        }

        public async Task<IActionResult> Kjøp()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Kjøp(Aksje aksje)
        {
            //Sjekker om aksje som skal kjøpes allerede eksisterer
            var alreadyExists = await _db.Aksje.FirstOrDefaultAsync(a => a.Navn == aksje.Navn);
            if (alreadyExists == null)
            {
                _db.Add(aksje);
                await _db.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(aksje);
        }
        

        //DELETE
        public async Task<IActionResult> Slett(int id)
        {
            var aksje = await _db.Aksje.FindAsync(id);
            _db.Aksje.Remove(aksje);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //GET - EDIT
        public async Task<IActionResult> Endre(int id)
        {
            var aksje = await _db.Aksje.FindAsync(id);
            return View(aksje);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Endre(Aksje aksje)
        {
            if (ModelState.IsValid)
            {
                _db.Update(aksje);
                await _db.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(aksje);
        }
    }
}
