using Microsoft.AspNetCore.Mvc;
using TournamentTracker.UI.DataAccess;

namespace TournamentTracker.UI.Controllers
{
    public class TournamentController : Controller
    {
        public TournamentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Tournaments.ToList();
            return View(data);
        }


        private readonly ApplicationDbContext _context;
    }
}
