using Microsoft.EntityFrameworkCore;
using ReactAspCRUDBackend.Models;

namespace ReactAspCrudBackend.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         optionsBuilder.UseSqlServer("Data Source=student-sqlserver5.database.windows.net; Initial Catalog=student-sqldb; User Id=studentadmin; password=capstone_5656; TrustServerCertificate= True");
        }
    }
}