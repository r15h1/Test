using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModelBindingToCollection.Controllers
{
    public class SimpleIntArrayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int[] age)
        {
            return View(age);
        }
    }
}
