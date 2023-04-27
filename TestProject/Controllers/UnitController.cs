using Microsoft.AspNetCore.Mvc;

namespace TestProject.Controllers
{
    public class UnitController : Controller
    {
        public IActionResult StudentsView()
        {
            return RedirectToAction("StudentsView");
        }
    }
}
