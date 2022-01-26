using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEmptyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEmptyProject.Controllers
{
    public class PersonController : Controller
    {
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
    }
}
