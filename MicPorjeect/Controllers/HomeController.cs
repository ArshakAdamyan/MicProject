using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MicPorjeect.Models;

namespace MicPorjeect.Controllers
{
    public class HomeController : Controller
    {
        Context db;

        public HomeController(Context context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.WashingMachine.ToList());
        }

    }
}
