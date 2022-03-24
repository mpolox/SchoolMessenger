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
        public Student AddStudent(Student aStudent)
        {
            _context.Students.Add(aStudent);            
            _context.SaveChanges();
            return (aStudent);
        }

        public bool DeleteStudentById(int id)
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

        public Student GetStudentByEmail(string email)
        {
            var response = _context.Students.FirstOrDefault(x => x.Email == email);
            return response;
        }

        public Student GetStudentById(int id)
        {
            var response = _context.Students.FirstOrDefault(x => x.Id == id);
            return response;
        }

        public IEnumerable<Student> GetStudentByName(string name)
        {
            var response = _context.Students.Where(x => x.FirstName == name).ToList();
            return response;
        }

        public IEnumerable<Student> GetStudents()
        {
            var students = _context.Students.ToList();
            return students;
        }

        public IEnumerable<Student> GetByParentId(int id)
        {
            //var response = _context.Parents.Where(x => x.Id == id).Select(c => c.Students).FirstOrDefault();
            var response = _context.ParentStudents.Where(x => x.Parent.Id == id).Select(s => s.Student).ToList();
            return response;
        }
        #endregion

        #region Parents
        public Parent AddParent(Parent aParent)
        {
            _context.Parents.Add(aParent);
            _context.SaveChanges();
            return (aParent);
        }

        public bool DeleteParenttById(int id)
        {
            var myParent = _context.Parents.FirstOrDefault(x => x.Id == id);
            if (myParent == null)
            {
                return false;
            }
            _context.Remove(myParent);
            _context.SaveChanges();
            return true;
        }

        public Parent GetParentByEmail(string email)
        {
            var response = _context.Parents.FirstOrDefault(x => x.Email == email);
            return response;
        }

        public Parent GetParentById(int id)
        {
            var response = _context.Parents.FirstOrDefault(x => x.Id == id);
            return response;
        }

        public IEnumerable<Parent> GetParentByName(string name)
        {
            var response = _context.Parents.Where(x => x.FirstName == name).ToList();
            return response;
        }

        public IEnumerable<Parent> GetParents()
        {
            var response = _context.Parents.ToList();
            return response;
        }

        #endregion


    }
}
