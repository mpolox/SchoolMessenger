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

        public Student AddStudent(Student aStudent)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByEmail(string email)
        {
            return s1;
        }

        public Student GetStudentById(int id)
        {
            return s1;
        }

        public Student GetStudentByName(string name)
        {
            return s1;
        }

        public IEnumerable<Student> GetStudents()
        {
            var students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            return students;
        }
    }
}
