using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication23.Models;

namespace WebApplication23.Controllers
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
        public IActionResult Login(User user)
        {
            return PartialView(user);
        }

        [HttpGet]
        public IActionResult LoginModal()
        {
            return PartialView("login");
        }

        [HttpPost]
        public IActionResult Register(RegisterUser registerUser)
        {
            return PartialView(registerUser);
        }

        [HttpGet]
        public IActionResult RegisterModal()
        {
            return PartialView("Register");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
