using Microsoft.AspNetCore.Mvc;

namespace app1_test.controllers;

    [Route("[Controller]/[Action]")]
    public class HomeController : Controller
    {
    [Route("")]
    [Route("~/")]
    [Route("~/home")]
    public IActionResult Index()
        {
            return View();
        }

        public IActionResult signup()
        {
            return View();
        }

        public IActionResult forgetten()
        {
            return View();
        }

    }



