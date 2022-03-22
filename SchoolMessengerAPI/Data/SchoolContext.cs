using Microsoft.EntityFrameworkCore;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public class SchoolContext: DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) 
        {

        }

        public DbSet<Parent> Parents { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
