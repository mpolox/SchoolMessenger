using Microsoft.EntityFrameworkCore;
using SchoolMessengerAPI.Data.Interfaces;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public class SubjectRepo : ISubjectRepo

    {
        private readonly SchoolContext _context;

        public SubjectRepo(SchoolContext context)
        {
            _context = context;
        }

        public async Task<Subject> AddSubject(Subject subject)
        {
            await _context.AddAsync(subject);
            await _context.SaveChangesAsync();
            return subject;
        }

        public async Task<IEnumerable<Subject>> GetByCredits(int credits)
        {
            var response = await _context.Subjects.Where(x => x.Credits == credits).ToListAsync();
            return response;
        }

        public async Task<Subject> GetById(int id)
        {
            var response = await _context.Subjects.FirstOrDefaultAsync(x => x.Id == id);
            return response;
        }

        public async Task<IEnumerable<Subject>> GetSubjects()
        {
            var response = await _context.Subjects.ToListAsync();
            return response;
        }        
    }
}
