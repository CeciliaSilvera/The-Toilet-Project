using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ToiletProject.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ToiletProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogedIn()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginUserViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View();

            return RedirectToAction("LogedIn");
        }
        [HttpGet]
        public IActionResult Registrer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrer(RegistrerViewModel viewModel)
        {
            if (!ModelState.IsValid)
            return View();

            return RedirectToAction("LogedIn");
        }
    }
}
