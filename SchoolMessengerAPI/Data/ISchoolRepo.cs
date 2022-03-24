using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public interface ISchoolRepo
    {
        #region Students
        public IEnumerable<Student> GetStudents();
        public Student GetStudentById(int id);
        public IEnumerable<Student> GetStudentByName(string name);
        public Student GetStudentByEmail(string email);
        public Student AddStudent(Student aStudent);
        public bool DeleteStudentById(int id);
        public IEnumerable<Student> GetByParentId(int id);
        #endregion

        #region Parents
        public IEnumerable<Parent> GetParents();
        public Parent GetParentById(int id);
        public IEnumerable<Parent> GetParentByName(string name);
        public Parent GetParentByEmail(string email);
        public Parent AddParent(Parent aStudent);
        public bool DeleteParenttById(int id);
        #endregion
        

    }
}
