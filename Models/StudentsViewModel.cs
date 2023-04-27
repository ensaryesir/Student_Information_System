using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Information_System.Models
{
    public class StudentsViewModel
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }


        [DisplayName("Last Name")]
        public string LastName { get; set; }

        //[DisplayName("Student Number")]
        //public int StudentNo { get; set; }

        [DisplayName("E-mail Adress")]
        public string Email { get; set; }

        //[DisplayName("Phone Number")]
        //public string PhoneNumber { get; set; }

        [DisplayName("Date Of Birth")]
        public DateTime BirthDate { get; set; }

        //[DisplayName("Gender")]
        //public string Gender { get; set; }

        //[DisplayName("Address")]
        //public string Address { get; set; }

        //[DisplayName("Department")]
        //public string Department { get; set; }

        //[DisplayName("GPA")]
        //public int GPA { get; set; }

        //public DateTime RegistrationDate { get; set; }

        //public Boolean Graduated { get; set; }

        [DisplayName("Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
    
}
