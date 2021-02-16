using System;
using Microsoft.AspNetCore.Mvc;
namespace HelloASP
{
    public class HomeController : Controller
                //HomeController will be called Home in View
    {
        //Requests
        //Localhost:5000
            
        // Index
        [HttpGet("")] // can collapse both
        public IActionResult Home()
        {
            return View();
        }

        //----------------------------------------------
        //Projects
        [HttpGet]
        [Route("Projects")] 
        public IActionResult Projects()
        {
            return View();
        }
        
        //---------------------------------------------
        //Contact
        [HttpGet]
        [Route("Contact")] 
        public IActionResult Contact()
        {
            return View();
        }
    }
}