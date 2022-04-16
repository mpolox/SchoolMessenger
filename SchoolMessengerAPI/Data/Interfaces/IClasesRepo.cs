using SchoolMessengerAPI.Dtos;
using SchoolMessengerAPI.Dtos.Read;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data.Interfaces
{
    public interface IClasesRepo
    {
        public Task<Clase> GetClaseById(int id);
        public Task<IEnumerable<Clase>> GetClaseByShortName(string shortName);
        public Task<IEnumerable<Clase>> GetClaseByCredit(int credits);
        public Task<IEnumerable<Clase>> GetClases();
        public Task<IEnumerable<Clase>> GetClasesByStudentId(int studentId);
        public Task<IEnumerable<ClaseDtoR>> GetClaseaByStudentName(string studentName);
        public Task<IEnumerable<Clase>> GetClasesByStudentMatricula(string matricula);
        public Task<IEnumerable<ClaseDtoR>> GetClasesByTeacherId(int id);
        public Task<IEnumerable<Student>> GetClasesByX();
    }
}
