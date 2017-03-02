using Microsoft.AspNetCore.Mvc;
using ModelBindingToCollection.Models;
using System.Collections.Generic;

namespace ModelBindingToCollection.Controllers
{
    public class SimpleDictionaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IDictionary<int, Vehicle> vehicles)
        {
            return View(vehicles);
        }
    }
}