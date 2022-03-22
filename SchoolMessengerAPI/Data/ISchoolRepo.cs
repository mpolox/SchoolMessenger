using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public interface ISchoolRepo
    {
        #region Students
        public IEnumerable<Student> GetStudents();
        public Student GetStudentById(int id);
        public Student GetStudentByName(string name);
        public Student GetStudentByEmail(string email);
        public Student AddStudent(Student aStudent);
        public bool DeleteStudentById(int id);
        #endregion

    }
}
