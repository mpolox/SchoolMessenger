using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public class SchoolRepo : ISchoolRepo
    {
        private readonly SchoolContext _context;

        public SchoolRepo(SchoolContext context)
        {
            _context = context;
        }

        #region Students
        public Student AddStudent(Student aStudent)
        {
            _context.Students.Add(aStudent);            
            _context.SaveChanges();
            return (aStudent);
        }

        public bool DeleteStudentById(int id)
        {
            var myStudent = _context.Students.FirstOrDefault(x => x.Id == id);
            if (myStudent == null)
            {
                return false;
            }
            _context.Remove(myStudent);
            _context.SaveChanges();
            return true;
        }

        public Student GetStudentByEmail(string email)
        {
            var response = _context.Students.FirstOrDefault(x => x.Email == email);
            return response;
        }

        public Student GetStudentById(int id)
        {
            var response = _context.Students.FirstOrDefault(x => x.Id == id);
            return response;
        }

        public Student GetStudentByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            var students = _context.Students.ToList();
            return students;
        }

        #endregion


    }
}
