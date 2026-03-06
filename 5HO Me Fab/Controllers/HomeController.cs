//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
using _5HO_Me_Fab.Models;
using Microsoft.AspNetCore.Mvc;

namespace _5HO_Me_Fab.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Index(UserInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            return RedirectToAction("Result", model);
        }

        public IActionResult Result(UserInputModel model)
        {
            return View("~/Views/Home/Result.cshtml", model);
        }
    }
}
