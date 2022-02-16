using Microsoft.AspNetCore.Mvc;
using MVCEmptyProject.Data;
using MVCEmptyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEmptyProject.Controllers
{
    public class CarController : Controller
    {
        public readonly ApplicationDbContext _context;

        public CarController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Cars.ToList());
        }
        public IActionResult CreateCar()
        { 
            return View(); 
        }
        [HttpPost]
        public IActionResult CreateCar(Car car)
        {
            if(ModelState.IsValid)
            {
                _context.Cars.Add(car);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCar(string regNumber)
        {
            var carToDelete = _context.Cars.FirstOrDefault(x => x.RegNumber == regNumber);
            _context.Cars.Remove(carToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
