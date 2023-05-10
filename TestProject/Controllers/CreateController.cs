using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using TestProject.DataDB;

namespace TestProject.Controllers
{

    public class CreateController : Controller
    {
        private readonly string _connectionString;

        public CreateController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            TestDBContext testDBContext = new TestDBContext();
            var data = testDBContext.Employees.ToList();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO StudentInformations (FirstName,LastName,StudentNo,Email,PhoneNumber,IdentificationNumber,Department,Adress,Gender,BirthDate,RegistrationDate) " +
                                                        "VALUES (@Name,@Surname,@StudentNo,@Email,@Phone,@TC,@Department,@Adress,@Gender,@BirthDate,@RegistrationDate)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", student.FirstName);
                    command.Parameters.AddWithValue("@Surname", student.LastName);
                    command.Parameters.AddWithValue("@StudentNo", student.StudentNo);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@Phone", student.PhoneNumber);
                    command.Parameters.AddWithValue("@TC", student.IdentificationNumber);
                    command.Parameters.AddWithValue("@Department", student.Department);
                    command.Parameters.AddWithValue("@Adress", student.Address);
                    command.Parameters.AddWithValue("@Gender", student.Gender);
                    command.Parameters.AddWithValue("@BirthDate", student.BirthDate);
                    command.Parameters.AddWithValue("@RegistrationDate", student.RegistrationDate);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        // veri ekleme başarısız oldu
                        return RedirectToAction("Create");
                    }
                }
            }
            //return RedirectToAction("Index", "Home");
        }
    }
}
