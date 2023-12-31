﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDoll.Controllers
{
    public class HelloWorldController : Controller
    {
        //Part -3 add view
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        /* public string Index()
        {
            return "This is my default action...";
        }
         


        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
         {
             return "This is the Welcome action method...";
         }
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        */

    }
}
