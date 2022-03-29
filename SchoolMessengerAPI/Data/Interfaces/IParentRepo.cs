using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data.Interfaces
{
    public interface IParentRepo
    {
        #region Parents
        public Task<IEnumerable<Parent>> GetParents();
        public Task<Parent> GetParentById(int id);
        public Task<IEnumerable<Parent>> GetParentByName(string name);
        public Task<Parent> GetParentByEmail(string email);
        public Task<Parent> AddParent(Parent aStudent);
        public Task<bool> DeleteParenttById(int id);
        #endregion
    }
}
