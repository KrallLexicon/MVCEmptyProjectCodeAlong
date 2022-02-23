using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEmptyProject.Data;
using MVCEmptyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEmptyProject.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PersonController(ApplicationDbContext context)
        {
            _context = context; 
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckPerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckPerson(string name, int age)
        {
            PersonModel model = new PersonModel();

            model.Age = age;
            model.Name = name;

            ViewBag.Message = PersonModel.Check(name, age);
            return View();
        }

        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("Test", "This is a test session");
            return View();
        }
        public IActionResult GetSession()
        {
            ViewBag.Message = HttpContext.Session.GetString("Test");
            return View(); 
        }

        [Authorize(Roles ="Admin")]
        public IActionResult ListPeople()
        {
            //if (Person.listOfPeople.Count == 0)
            //    Person.GeneratePeople();
            //return View(Person.listOfPeople);
            
            return View(_context.People.ToList()); 
        }

        public IActionResult AddPerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            //person.Id = Person.nextId;
            //Person.nextId++;
            //Person.listOfPeople.Add(person);
            if(ModelState.IsValid)
            {
                _context.People.Add(person);
                _context.SaveChanges(); 
            }

            return RedirectToAction("ListPeople");
        }
        public IActionResult DeletePerson(int id)
        {
            //var person = Person.listOfPeople.Find(x => x.Id == id);
            //Person.listOfPeople.Remove(person);

            var personToDelete = _context.People.Find(id);
            _context.People.Remove(personToDelete);
            _context.SaveChanges(); 

            return RedirectToAction("ListPeople");
        }
    }
}
