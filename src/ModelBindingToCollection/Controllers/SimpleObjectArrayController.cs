using Microsoft.AspNetCore.Mvc;
using ModelBindingToCollection.Models;
using System.Collections.Generic;

namespace ModelBindingToCollection.Controllers
{
    public class SimpleObjectArrayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IEnumerable<Vehicle> vehicles)
        {
            return View(vehicles);
        }
    }
}
