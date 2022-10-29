using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Stock_trading.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_trading.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
