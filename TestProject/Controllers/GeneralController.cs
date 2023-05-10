using Microsoft.AspNetCore.Mvc;

namespace TestProject.Controllers
{
    public class GeneralController : Controller
    {
        public IActionResult GeneralInformation()
        {
            return View();
        }

        public IActionResult PersonalInformation()
        {
            return View();
        }

        public IActionResult YOKSIS()
        {
            return View();
        }

        public IActionResult LessonTaken()
        {
            return View();
        }

        public IActionResult ConsultantInfo() 
        {
            return View();
        }
        public IActionResult ExamSchedule()
        {
            return View();
        }

        public IActionResult AcademicCalendar()
        {
            return View();
        }

        
        public IActionResult IntershipInfo()
        {
            return View();
        }

        public IActionResult ExamResult()
        {
            return View();
        }

        public IActionResult Charts()
        {
            return View();
        }
    }
}
