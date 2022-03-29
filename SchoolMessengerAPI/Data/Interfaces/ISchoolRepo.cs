using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data.Interfaces
{
    public interface ISchoolRepo
    {
        Task<Student> GetStudentById(int id);
        Task<IEnumerable<Student>> GetStudents();
    }
}