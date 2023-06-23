using Microsoft.AspNetCore.Mvc;
using TournamentTracker.UI.DataAccess;
using TournamentTracker.UI.Models;

namespace TournamentTracker.UI.Controllers
{
    public class TournamentController : Controller
    {
        public TournamentController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET
        public IActionResult Index()
        {
            //var data = _context.Tournaments.ToList();
            IEnumerable<Tournament> data = _context.Tournaments;
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        public IActionResult Create(Tournament obj)
        {
            if (ModelState.IsValid)
            {
                _context.Tournaments.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index"); 
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _context.Tournaments.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Tournament obj)
        {


            if (ModelState.IsValid)
            {
                _context.Tournaments.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
                //return RedirectToAction("Index", "Category");
            }
            return View();
        }


        private readonly ApplicationDbContext _context;
    }
}
