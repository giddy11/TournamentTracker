using Microsoft.AspNetCore.Mvc;
using TournamentTracker.UI.Models;

namespace TournamentTracker.UI.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View(_persons);
        }

        public IActionResult Create()
        {
            var person = new Person();
            return View(person);
        }

        public IActionResult CreatePerson(Person person)
        {
            _persons.Add(person);
            return RedirectToAction(nameof(Index));
            //return View("Index");
        }


        private static List<Person> _persons = new List<Person>();
    }
}
