using Microsoft.AspNetCore.Mvc;
using ModelBindingToCollection.Models;
using System.Collections.Generic;

namespace ModelBindingToCollection.Controllers
{
    public class ObjectArrayNestedPropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IEnumerable<VehicleNestedProperty> vehicles)
        {
            return View(vehicles);
        }
    }
}