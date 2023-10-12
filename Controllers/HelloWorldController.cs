using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDoll.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
       {
           return "This is my default action...";
       }
        /*public IActionResult Index()
         {
             return View();
         }*/


         // 
         // GET: /HelloWorld/Welcome/ 

         public string Welcome()
         {
             return "This is the Welcome action method...";
         }
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        

    }
}
