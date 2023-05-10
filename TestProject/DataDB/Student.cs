using System;
using System.Collections.Generic;

#nullable disable

namespace TestProject.DataDB
{
    public partial class Student
    {
        public int Id { get; set; }
        public string StudentNo { get; internal set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; internal set; }
        public DateTime RegistrationDate { get; internal set; }
        public string Gender { get; internal set; }
        public string IdentificationNumber { get; internal set; }
    }
}
