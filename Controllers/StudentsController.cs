using Microsoft.AspNetCore.Mvc;
using Student_Information_System.DAL;
using Student_Information_System.Models;
using Student_Information_System.Models.DBEntities;

namespace Student_Information_System.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentsDBContext _context;

        public StudentsController(StudentsDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
			List<StudentsViewModel> studentList = new List<StudentsViewModel>();

			if (students != null)
            {
                
				foreach (var student in students)
                {
                    var StudentsViewModel = new StudentsViewModel()
                    {
						Id = student.Id,
						FirstName = student.FirstName,
						LastName = student.LastName,
						Email = student.Email,
						BirthDate = student.BirthDate,
						
						//StudentNo = student.StudentNo,





					};
					studentList.Add(StudentsViewModel);
					
				}
				return View(studentList);
			}
			return View(studentList);


        }

    }
}

