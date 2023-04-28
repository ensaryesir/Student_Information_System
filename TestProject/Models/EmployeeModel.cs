namespace TestProject.Models
{
    public class EmployeeModel
    {
        public List<EmplDetail> EmplDetailList { get; set; }
    }
    public class EmplDetail
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public int StudentNo { get; internal set; }
        public object Gender { get; internal set; }

        //public int PhoneNumber { get; set; }
        //public DateTime BirthDate { get;  set; }
        //public int StudentNo { get; set; }
        //public string Gender { get; set; }
        //public float GPA { get; set; }
        //public DateTime RegistrationDate { get; set; }
        //public DateTime Graduated { get; set; }
    }
}
