using Microsoft.AspNetCore.Mvc;

namespace TestProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginAdmin() 
        {
            return View();
        }

        public IActionResult LoginStudent() 
        {
            return View();
        }

        public IActionResult LoginAcademician()
        {
            return View();
        }
    }
}
