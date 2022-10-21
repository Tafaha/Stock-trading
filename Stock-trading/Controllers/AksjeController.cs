using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stock_trading.Models;
using System.Linq;
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
            _db.Add(aksje);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //GET - DELETE
        public async Task<IActionResult> Slett(int id)
        {
            var aksje = await _db.Aksje.FindAsync(id);
            _db.Aksje.Remove(aksje);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
