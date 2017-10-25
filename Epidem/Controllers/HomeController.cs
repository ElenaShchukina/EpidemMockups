using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Epidem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Questionnaire()
        {
            return View();
        }

        public IActionResult QuestionnaireFinish()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Diagrams()
        {
            return View();
        }
    }
}
