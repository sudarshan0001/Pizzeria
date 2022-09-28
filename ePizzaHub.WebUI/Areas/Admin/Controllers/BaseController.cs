using Pizzeria.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.WebUI.Areas.Admin.Controllers
{
    [CustomAuthorize(Roles ="Admin")]
    [Area("Admin")]
    public class BaseController : Controller
    {
       
    }
}
