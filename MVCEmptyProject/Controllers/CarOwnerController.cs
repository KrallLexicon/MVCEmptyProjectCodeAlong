using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCEmptyProject.Data;
using MVCEmptyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEmptyProject.Controllers
{
    public class CarOwnerController : Controller
    {
        public readonly ApplicationDbContext _context;

        public CarOwnerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["RegNumber"] = new SelectList(_context.Cars, "RegNumber", "RegNumber");
            ViewData["PersonId"] = new SelectList(_context.People, "Id", "FirstName");
                       
            
            return View();
        }
        [HttpPost]
        public IActionResult CreateCarOwner(CarOwner carOwner)
        {
            
            _context.CarOwners.Add(carOwner);
            _context.SaveChanges();
            return RedirectToAction("Index"); 
        }
    }
}
