using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using TournamentTracker.UI.DataAccess;
using TournamentTracker.UI.Hubs;
using TournamentTracker.UI.Interfaces;
using TournamentTracker.UI.Models;

namespace TournamentTracker.UI.Controllers
{
    public class TournamentController : Controller
    {
        public TournamentController(ITournamentRepository tournamentRepository)
        {
            _tournamentRepository = tournamentRepository;
        }

        //GET
        public async Task<IActionResult> Index()
        {
            //var data = _context.Tournaments.ToList();
            IEnumerable<Tournament> data = await _tournamentRepository.GetAll();
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
                _tournamentRepository.Add(obj);
                return RedirectToAction("Index"); 
            }
            return View(obj);
        }

        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _tournamentRepository.GetByIdAsync(id);
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
                _tournamentRepository.Update(obj);
                return RedirectToAction("Index");
                //return RedirectToAction("Index", "Category");
            }
            return View();
        }


        //private readonly ApplicationDbContext _context;
        private readonly ITournamentRepository _tournamentRepository;
    }
}
