using Microsoft.EntityFrameworkCore;
using SchoolMessengerAPI.Data.Interfaces;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public class ParentRepo : IParentRepo
    {
        private readonly SchoolContext _context;
        public ParentRepo(SchoolContext context)
        {
            _context = context;
        }
        #region Parents
        public async Task<Parent> AddParent(Parent aParent)
        {
            await _context.Parents.AddAsync(aParent);
            await _context.SaveChangesAsync();
            return (aParent);
        }

        public async Task<bool> DeleteParenttById(int id)
        {
            var myParent = await _context.Parents.FirstOrDefaultAsync(x => x.Id == id);
            if (myParent == null)
            {
                return false;
            }
            _context.Remove(myParent);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Parent> GetParentByEmail(string email)
        {
            var response = await _context.Parents.FirstOrDefaultAsync(x => x.Email == email);
            return response;
        }

        public async Task<Parent> GetParentById(int id)
        {
            var response = await _context.Parents.FirstOrDefaultAsync(x => x.Id == id);
            return response;
        }

        public async Task<IEnumerable<Parent>> GetParentByName(string name)
        {
            var response = await _context.Parents.Where(x => x.FirstName == name).ToListAsync();
            return response;
        }

        public async Task<IEnumerable<Parent>> GetParents()
        {
            var response = await _context.Parents.ToListAsync();
            return response;
        }

        #endregion
    }
}
