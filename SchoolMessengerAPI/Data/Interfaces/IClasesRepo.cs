using SchoolMessengerAPI.Dtos;
using SchoolMessengerAPI.Dtos.Read;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data.Interfaces
{
    public interface IClasesRepo
    {
        public Task<ClaseDtoR> GetClaseById(int id);
        public Task<IEnumerable<ClaseDtoR>> GetClaseByShortName(string shortName);
        public Task<IEnumerable<ClaseDtoR>> GetClaseByCredit(int credits);
        public Task<IEnumerable<ClaseDtoR>> GetClases();
        public Task<IEnumerable<ClaseDtoR>> GetClasesByStudentId(int studentId);
        public Task<IEnumerable<ClaseDtoR>> GetClaseaByStudentName(string studentName);
        public Task<IEnumerable<ClaseDtoR>> GetClasesByStudentMatricula(string matricula);
        public Task<IEnumerable<ClaseDtoR>> GetClasesByTeacherId(int id);
        public Task<IEnumerable<ClaseDtoR>> GetClasesByTeacherName(string teacherName);
        public Task<IEnumerable<ClaseDtoR>> GetClasesBySubjectId(int id);
    }
}
