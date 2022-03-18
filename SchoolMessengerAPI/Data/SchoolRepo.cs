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
        public Student GetStudentByEmail(string email)
        {
            throw new NotImplementedException();

            var response = _context.Students.FirstOrDefault();
            return response;
        }

        public Student GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            throw new NotImplementedException();
        }
    }
}
