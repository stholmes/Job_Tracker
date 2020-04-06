using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Job_Tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace Job_Tracker.Controllers
{
    public class HomeController : Controller
    {
        private JTContext dbContext;
        public HomeController(JTContext context){
            dbContext = context;
        }
        public IActionResult Index()
        {

            System.Console.WriteLine();
            return View();
        }

        [HttpGet("new")]
        public IActionResult NewJob()
        {
            Job viewModel = new Job();
            return View(viewModel);
        }
    }
}
