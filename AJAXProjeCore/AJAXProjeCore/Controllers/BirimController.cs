using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AJAXProjeCore.Models;

namespace AJAXProjeCore.Controllers
{
    public class BirimController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
