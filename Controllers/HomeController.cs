using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Portfolio1.Controllers {
    public class HomeController : Controller {
        [HttpGet ("")]
        public IActionResult Index () {
            return View("Index");
        }

        [HttpGet ("projects/{username}/{firstname}")]
        public string projects (string username, string firstname) {
            
            return $"this is my projects, and my username = {username}, my firstname is {firstname}";
        }

        [HttpGet ("contact")]
        public IActionResult contactphone () {
            return View("Contact");
        }
    }
}