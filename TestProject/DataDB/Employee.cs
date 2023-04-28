using System;
using System.Collections.Generic;

#nullable disable

namespace TestProject.DataDB
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        //public object Gender { get; internal set; } // HATA ?
        public string PhoneNumber { get; set; }
    }
}
