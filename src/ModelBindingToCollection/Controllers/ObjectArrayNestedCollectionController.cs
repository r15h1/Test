using Microsoft.AspNetCore.Mvc;
using ModelBindingToCollection.Models;
using System.Collections.Generic;

namespace ModelBindingToCollection.Controllers
{
    public class ObjectArrayNestedCollectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IEnumerable<VehicleNestedCollection> vehicles)
        {
            return View(vehicles);
        }
    }
}