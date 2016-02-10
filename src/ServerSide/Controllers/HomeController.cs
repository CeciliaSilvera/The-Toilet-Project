using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;
using ServerSide.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ServerSide.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        

    }
}
