using SchoolMessengerAPI.Data.Interfaces;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public class MockSchoolRepo : ISchoolRepo
    {

        Student s1 = new Student
        {
            Birthday = new DateTime(),
            Curp = "curp",
            Email = "mpolox@gmail.com",
            FirstName = "Marcopolo",
            Id = 1,
            MotherName = "Ramos",
            ParentName = "Peña",
            StudentId = "clave3423423"
        };
        Student s2 = new Student
        {
            Birthday = new DateTime(),
            Curp = "curp2",
            Email = "mpolox@gmail.com2",
            FirstName = "Marcopolo2",
            Id = 2,
            MotherName = "Ramos2",
            ParentName = "Peña2",
            StudentId = "clave3423423_2"
        };

        public Task<Student> GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetStudents()
        {
            throw new NotImplementedException();
        }
    }
}
