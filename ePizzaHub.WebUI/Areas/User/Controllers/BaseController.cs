using Pizzeria.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.WebUI.Areas.User.Controllers
{
    [CustomAuthorize(Roles = "User")]
    [Area("User")]
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
