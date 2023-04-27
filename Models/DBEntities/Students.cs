using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace Student_Information_System.Models.DBEntities
{
    public class Students
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int StudentNo { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string Department { get; set; }

        public int GPA { get; set; }

        public DateTime RegistrationDate { get; set; }

        public Boolean Graduated { get; set; }
        
        
    }
}
