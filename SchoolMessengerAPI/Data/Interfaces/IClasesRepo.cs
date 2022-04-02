using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data.Interfaces
{
    public interface IClasesRepo
    {
        public Task<IEnumerable<Clase>> GetClases();
        public Task<IEnumerable<Student>> GetClasesByX();
    }
}
