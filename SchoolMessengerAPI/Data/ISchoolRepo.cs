using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public interface ISchoolRepo
    {
        public IEnumerable<Student> GetStudents();
        public Student GetStudentById(int id);
        public Student GetStudentByName(string name);
        public Student GetStudentByEmail(string email);
    }
}
