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

        public Parent AddParent(Parent aStudent)
        {
            throw new NotImplementedException();
        }

        public Student AddStudent(Student aStudent)
        {
            throw new NotImplementedException();
        }

        public bool DeleteParenttById(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetByParentId(int id)
        {
            throw new NotImplementedException();
        }

        public Parent GetParentByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Parent GetParentById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Parent> GetParentByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Parent> GetParents()
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudentByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            throw new NotImplementedException();
        }
    }
}
