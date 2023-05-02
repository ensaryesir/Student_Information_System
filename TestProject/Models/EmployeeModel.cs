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
        public string StudentNo { get; internal set; }
        public string PhoneNumber { get; internal set; }
        public DateTime BirthDate { get; internal set; }
        public DateTime RegistrationDate { get; internal set; }
        public string Gender { get; internal set; }
        public string IdentificationNumber { get; internal set; }

        //public float GPA { get; set; }
        //public DateTime Graduated { get; set; }
    }
}
