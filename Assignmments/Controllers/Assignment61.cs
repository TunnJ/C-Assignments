using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignmments.Controllers
{
    public class Assignment61 : Controller
    {
        // GET: /<controller>/
        public IActionResult Student(int id = 0)
        {
            if (id < 5)
            {
                return View("Low");
            }
            else if (id < 9)
            {
                return View("Medium");
            }
            else
            {
                return View("Admin");
            }
        }
    }
}
