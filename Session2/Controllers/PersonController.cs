using Microsoft.AspNetCore.Mvc;
using Session2.Models;
using Session2.Service;

namespace Session2.Controllers
{
    public class PersonController : Controller
    {
      
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var persons = _personService.GetPersons();
            return View(persons);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var person = _personService.GetPersonById(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _personService.CreatePerson(person);
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        public IActionResult Edit(int id)
        {
            var person = _personService.GetPersonById(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                _personService.UpdatePerson(person);
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }

        public IActionResult Delete(int id)
        {
            var person = _personService.GetPersonById(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _personService.DeletePerson(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
