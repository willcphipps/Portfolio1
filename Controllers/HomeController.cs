using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Portfolio1.Controllers {
    public class HomeController : Controller {
        [HttpGet ("")]
        public IActionResult Index () {
            return View("Index");
        }


        [HttpGet ("projects")]
        public IActionResult projects () {
    
            return View("Projects");
        }

        [HttpGet ("contact")]
        public IActionResult contactphone () {
            return View("Contact");
        }
    }
}