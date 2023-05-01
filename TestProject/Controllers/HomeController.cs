using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestProject.DataDB;
using TestProject.Models;

namespace TestProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            EmployeeModel employeeModel = new EmployeeModel();
            employeeModel.EmplDetailList = new List<EmplDetail>();

            TestDBContext testDBContext = new TestDBContext();
            var data = testDBContext.Employees.ToList();
            foreach (var item in data)
            {
                employeeModel.EmplDetailList.Add(NewMethod(item));
            }
            return View(employeeModel);
        }

        private static EmplDetail NewMethod(Employee item)
        {
            return new EmplDetail
            {
                Id = item.Id,
                StudentNo = item.StudentNo,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Gender = item.Gender,
                Department = item.Department,
                Email = item.Email,
                Adress = item.Adress,
                PhoneNumber = item.PhoneNumber,
                BirthDate = item.BirthDate,
                RegistrationDate = item.RegistrationDate,
                IdentificationNumber = item.IdentificationNumber,
                //GPA = item.GPA,
                //Graduated = item.Graduated
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}