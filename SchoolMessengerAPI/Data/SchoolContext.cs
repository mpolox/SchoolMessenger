using Microsoft.EntityFrameworkCore;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public class SchoolContext: DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) 
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectClass> SubjectClasses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
    }
}
