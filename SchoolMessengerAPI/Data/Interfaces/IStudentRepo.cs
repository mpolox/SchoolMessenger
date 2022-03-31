using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data.Interfaces
{
    public interface IStudentRepo
    {
        #region Students
        public Task<IEnumerable<Student>> GetStudents();
        public Task<Student> GetStudentById(int id);
        public Task<IEnumerable<Student>> GetStudentByName(string name);
        public Task<Student> GetStudentByEmail(string email);
        public Task<Student> AddStudent(Student aStudent);
        public Task<bool> DeleteStudentById(int id);
        public Task<IEnumerable<Student>> GetByParentId(int id);

        public Task<IEnumerable<Parcial>> GetParcialesByStudentId(int id);
        #endregion
    }
}
