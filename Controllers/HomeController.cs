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
            Job test = dbContext.Jobs.FirstOrDefault();
            System.Console.WriteLine("*******************************************");
            System.Console.WriteLine(test.JobTitle);
            return View();
        }

        [HttpGet("new")]
        public IActionResult NewJob()
        {
            Job viewModel = new Job();
            return View(viewModel);
        }

        [HttpPost("new/job")]
        public IActionResult CreateJob(Job submittedData){
            System.Console.WriteLine("**************************************");
            System.Console.WriteLine(submittedData.JobTitle);
            return RedirectToAction("Index");
        }
    }
}
