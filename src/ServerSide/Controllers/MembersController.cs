using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ServerSide.Controllers
{
    public class MembersController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            if (User.Identity.IsAuthenticated)
                return $"User Loged in as {User.Identity.Name}....";
            else
                return "User not loged in...";

        }
    }
}
