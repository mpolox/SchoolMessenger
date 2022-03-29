using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data.Interfaces
{
    public interface ISubjectRepo
    {
        public Task<Subject> GetById(int id);
        public Task<IEnumerable<Subject>> GetSubjects();
        public Task<IEnumerable<Subject>> GetByCredits(int credits);
        public Task<Subject> AddSubject(Subject subject);
    }
}
