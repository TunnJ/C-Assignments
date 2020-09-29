using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignmments.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DummyController : Controller
    {
        // GET: /<controller>/
        public IActionResult Dummy1()
        {
            return View();
        }

        public IActionResult Dummy23(int id = 2)
        {
            if (id == 2)
            {
                return View("Dummy2");
            }
            else
            {
                return Content("Enter in the correct ID");
            }
        }

        [Route("[action]")]
        public IActionResult Dummy3()
        {
            return View();
        }
    }
}
