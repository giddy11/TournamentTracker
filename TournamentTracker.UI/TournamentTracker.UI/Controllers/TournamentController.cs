using Microsoft.AspNetCore.Mvc;
using TournamentTracker.UI.DataAccess;
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

        public async Task<IActionResult> Index()
        {
            IEnumerable<Tournament> data = await _tournamentRepository.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

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
            }
            return View();
        }

        public IActionResult Type(TournamentType tournamentType)
        {
            //if (TournamentType.ClassicLeague.Equals(tournamentType))
            if (TournamentType.ClassicLeague == tournamentType)
            {
                return View("ClassicLeague");
            }
            else if (TournamentType.Head2Head == tournamentType)
            {
                return View("Head2Head");
            }
            return View("Knockout");
        }

        public IActionResult ClassicLeague()
        {
            return View();
        }

        public IActionResult Head2Head()
        {
            return View();
        }

        public IActionResult Knockout()
        {
            return View();
        }

        private readonly ITournamentRepository _tournamentRepository;
    }
}
