using Microsoft.EntityFrameworkCore;
using SchoolMessengerAPI.Data.Interfaces;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public class SchoolRepo : ISchoolRepo
    {
        private readonly SchoolContext _context;

        public SchoolRepo(SchoolContext context)
        {
            _context = context;
        }

        #region Students
        public async Task <Student> AddStudent(Student aStudent)
        {
            await _context.Students.AddAsync(aStudent);            
            await _context.SaveChangesAsync();
            return (aStudent);
        }

        public async Task <bool> DeleteStudentById(int id)
        {
            var myStudent = _context.Students.FirstOrDefault(x => x.Id == id);
            if (myStudent == null)
            {
                return false;
            }
            _context.Remove(myStudent);
            _context.SaveChanges();
            return true;
        }

        public async Task <Student> GetStudentByEmail(string email)
        {
            var response = await _context.Students.FirstOrDefaultAsync(x => x.Email == email);
            return response;
        }

        public async Task <Student> GetStudentById(int id)
        {
            var response = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
            return response;
        }

        public async Task <IEnumerable<Student>> GetStudentByName(string name)
        {
            var response = _context.Students.Where(x => x.FirstName == name).ToList();
            return response;
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            var students = await _context.Students.ToListAsync();
            return students;
        }

        public async Task<IEnumerable<Student>> GetByParentId(int id)
        {
            //var response = _context.Parents.Where(x => x.Id == id).Select(c => c.Students).FirstOrDefault();
            var response = await _context.ParentStudents.Where(x => x.Parent.Id == id).Select(s => s.Student).ToListAsync();
            return response;
        }
        #endregion

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

        public async Task <IEnumerable<Parent>> GetParentByName(string name)
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
