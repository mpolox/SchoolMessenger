using Microsoft.EntityFrameworkCore;
using SchoolMessengerAPI.Data.Interfaces;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public class StudentRepo : IStudentRepo
    {
        private readonly SchoolContext _context;

        public StudentRepo(SchoolContext context)
        {
            _context = context;
        }

        #region Students
        public async Task<Student> AddStudent(Student aStudent)
        {
            await _context.Students.AddAsync(aStudent);
            await _context.SaveChangesAsync();
            return (aStudent);
        }

        public async Task<bool> DeleteStudentById(int id)
        {
            var myStudent = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (myStudent == null)
            {
                return false;
            }
            _context.Remove(myStudent);
            _context.SaveChanges();
            return true;
        }

        public async Task<Student> GetStudentByEmail(string email)
        {
            var response = await _context.Students.FirstOrDefaultAsync(x => x.Email == email);
            return response;
        }

        public async Task<Student> GetStudentById(int id)
        {
            var response = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
            return response;
        }

        public async Task<IEnumerable<Student>> GetStudentByName(string name)
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

        public async Task<IEnumerable<Parcial>> GetParcialesByStudentId(int id)
        {
            var result = _context.Students.Where(x => x.Id == id).Select(s => s.Parciales).FirstOrDefaultAsync().Result;
            return result;
        }
        #endregion
    }
}
