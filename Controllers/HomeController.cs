using homework1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace homework1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string name)
        {
            var reversedName = new string(name.Reverse().ToArray());
            ViewData["ReversedName"] = reversedName;
            return View();

        }

        public IActionResult Calcuter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcuter(int num1, int num2, string operation)
        {
            int result = 0;

            switch (operation)
            {
                case "add":
                    result = num1 + num2;
                    break;
                case "subtract":
                    result = num1 - num2;
                    break;
                case "multiply":
                    result = num1 * num2;
                    break;
                case "divide":
                    result = num1 / num2;
                    break;
                default:
                    ViewBag.Result = "Invalid operation selected.";
                    return View();
            }

            ViewBag.Result = result;

            return View();



        }
    
    }
        }
    