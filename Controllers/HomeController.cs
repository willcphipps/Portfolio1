using Microsoft.AspNetCore.Mvc;

namespace Portfolio1.Controllers {
    public class HomeController : Controller {
        [HttpGet ("")]
        public string index () {
            return "this is my index";
        }

        [HttpGet ("projects/{username}/{firstname}")]
        public string projects (string username, string firstname) {
            
            return $"this is my projects, and my username = {username}, my firstname is {firstname}";
        }

        [HttpGet ("contact")]
        public string contact () {
            return "this is my contact";
        }
    }
}