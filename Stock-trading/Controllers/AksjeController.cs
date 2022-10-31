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

        //GET - Index
        public async Task<IActionResult> Index()
        {
            return View(await _db.Aksjer.ToListAsync());  //Lister ut aksjene
        }

        //GET - Kjøp
        public IActionResult Kjøp()
        {
            return View();
        }

        //POST - Kjøp
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Kjøp(Aksje aksje)
        {
            //Sjekker om aksje som skal kjøpes allerede eksisterer
            var alreadyExists = await _db.Aksjer.FirstOrDefaultAsync(a => a.Navn == aksje.Navn);
            if (alreadyExists == null && ModelState.IsValid)    //sjekker også om input-verdien er gyldig
            {
                _db.Add(aksje);
                await _db.SaveChangesAsync();

                return RedirectToAction("Index");   
            }
            return View();
        }
        

        //Selg Aksje
        public async Task<IActionResult> Slett(int id)
        {
            var aksje = await _db.Aksjer.FindAsync(id);
            _db.Aksjer.Remove(aksje);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //GET - Endre
        public async Task<IActionResult> Endre(int id)
        {
            var aksje = await _db.Aksjer.FindAsync(id);
            return View(aksje);
        }

        //POST - Endre
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Endre(Aksje aksje)
        {
            if (ModelState.IsValid)     //sjekker om input-verdien er gyldig
            {
                _db.Update(aksje);
                await _db.SaveChangesAsync();

                return RedirectToAction("Index");
            }
             return View();
        }       
    }
}
