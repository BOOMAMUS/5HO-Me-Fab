using _5HO_Me_Fab.Models;
using Microsoft.AspNetCore.Mvc;

namespace _5HO_Me_Fab.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserInputModel());
            //return View("~/Views/Home/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Index(UserInputModel model)
        {
            model.TankOptions = new UserInputModel().TankOptions;

            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            return View("Result", model);
        }

        public IActionResult Result(UserInputModel model)
        {
            return View("~/Views/Home/Result.cshtml", model);
        }
    }
}
