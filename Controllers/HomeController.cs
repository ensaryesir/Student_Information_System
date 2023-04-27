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
                employeeModel.EmplDetailList.Add(new EmplDetail
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Department = item.Department,
                    Email = item.Email,
                    //StudentNo = item.StudentNo
                    //PhoneNumber = item.PhoneNumber,
                    //GPA = item.GPA,
                    //Graduated = item.Graduated
                    //Salery = item.Salery,
                });
            }
            return View(employeeModel);
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