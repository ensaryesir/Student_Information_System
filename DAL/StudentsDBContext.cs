using Microsoft.EntityFrameworkCore;
using Student_Information_System.Models.DBEntities;

namespace Student_Information_System.DAL
{
    public class StudentsDBContext : DbContext
    {
        public StudentsDBContext(DbContextOptions<StudentsDBContext> options) : base(options)
        {
        }

        public DbSet<Students> Students { get; set; }
    }
 
}
