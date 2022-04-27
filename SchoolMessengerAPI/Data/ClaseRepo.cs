using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SchoolMessengerAPI.Data.Interfaces;
using SchoolMessengerAPI.Dtos;
using SchoolMessengerAPI.Dtos.Read;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public class ClaseRepo : IClasesRepo

    {
        private readonly SchoolContext _context;
        private readonly IMapper _mapper;

        public ClaseRepo()
        {
        }

        public ClaseRepo(SchoolContext  context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClaseDtoR>> GetClaseaByStudentName(string studentName)        
        {

            var response = await (from cs in _context.ClaseStudents
                                   join c in _context.Clases
                                   on cs.Clase.Id equals c.Id
                                   join s in _context.Students
                                   on cs.Student.Id equals s.Id
                                   where s.FirstName == studentName
                                   select ( new ClaseDtoR
                                   {
                                       Description = c.Description,
                                       Materia = c.Subject.Name,
                                       Salon = c.Room.Name
                                   })).ToListAsync();

            return response;
        }

        public async Task<IEnumerable<ClaseDtoR>> GetClaseByCredit(int credits)
        {

            var response = await (from c in _context.Clases
                                  join s in _context.Subjects
                                  on c.SubjectId equals s.Id
                                  where s.Credits == credits
                                  select (new ClaseDtoR
                                  {
                                      Description = c.Description,
                                      Materia = c.Subject.Name,
                                      Salon = c.Room.Name
                                  })).ToListAsync();
            return response;
        }

        public async Task<ClaseDtoR> GetClaseById(int id)
        {
            var response = await (from c in _context.Clases
                                  where c.Id == id
                                  select (new ClaseDtoR
                                  {
                                      Description = c.Description,
                                      Materia = c.Subject.Name,
                                      Salon = c.Room.Name
                                  })).FirstOrDefaultAsync();
            return response;
        }

        public async Task<IEnumerable<ClaseDtoR>> GetClaseByShortName(string shortName)
        {
            var response = await (from s in _context.Subjects
                                  join c in _context.Clases
                                  on s.Id equals c.SubjectId
                                  where s.ShortName == shortName
                                  select (new ClaseDtoR
                                  {
                                      Description = c.Description,
                                      Materia = c.Subject.Name,
                                      Salon = c.Room.Name
                                  })).ToListAsync();
            return response;
        }

        public async Task<IEnumerable<ClaseDtoR>> GetClases()
        {
            var response = await _context.Clases.Select(c => new ClaseDtoR
            {
                Description = c.Description,
                Materia = c.Subject.Name,
                Salon = c.Room.Name
            }).ToListAsync();
            return response;
        }

        public async Task<IEnumerable<ClaseDtoR>> GetClasesByStudentId(int studentId)
        {
            var response = await (from cs in _context.ClaseStudents
                                  join c in _context.Clases
                                  on cs.Clase.Id equals c.Id
                                  join s in _context.Students
                                  on cs.Student.Id equals s.Id
                                  where s.Id == studentId
                                  select (new ClaseDtoR
                                  {
                                      Description= c.Description,   
                                      Materia = c.Subject.Name,
                                      Salon = c.Room.Name
                                  })).ToListAsync();
            return response;
        }

        public async Task<IEnumerable<ClaseDtoR>> GetClasesByStudentMatricula(string matricula)
        {
            var response = await(from cs in _context.ClaseStudents
                                 join c in _context.Clases
                                 on cs.Clase.Id equals c.Id
                                 join s in _context.Students
                                 on cs.Student.Id equals s.Id
                                 where s.StudentId == matricula
                                 select ( new ClaseDtoR
                                 {
                                     Description = c.Description,
                                     Materia = c.Subject.Name,  
                                     Salon = c.Room.Name
                                 })).ToListAsync();
            return response;
        }

        public async Task<IEnumerable<ClaseDtoR>> GetClasesByTeacherId(int id)
        {
            var response = await (from t in _context.Teachers
                                  join c in _context.Clases
                                  on t.Id equals c.TeacherId
                                  where t.Id == id
                                  select (new ClaseDtoR
                                  {
                                      Description = c.Description,
                                      Materia = c.Subject.Name,
                                      Salon = c.Room.Name
                                  })).ToListAsync();

            return response;
        }

        public async Task<IEnumerable<ClaseDtoR>> GetClasesByTeacherName(string teacherName)
        {

            //var resp = await (from t in _context.Teachers
            //                  join c in _context.Clases
            //                  on t.Id equals c.TeacherId
            //                  where t.FirstName == teacherName
            //                  select c).ToListAsync();

            //var response = _mapper.Map<List<Clase>, List<ClaseDtoR>>(resp);

            var response = await(from t in _context.Teachers
                                 join c in _context.Clases
                                 on t.Id equals c.TeacherId
                                 where t.FirstName == teacherName
                                 select (new ClaseDtoR
                                 {
                                     Description = c.Description,
                                     Materia = c.Subject.Name,
                                     Salon = c.Room.Name
                                 })).ToListAsync();

            return response;
        }

        public async Task<IEnumerable<ClaseDtoR>> GetClasesBySubjectId(int id)
        {

            var response = await (from s in _context.Subjects
                                  join c in _context.Clases
                                  on s.Id equals c.SubjectId
                                  where s.Id == id
                                  select (new ClaseDtoR
                                  {
                                      Description = c.Description,
                                      Materia = c.Subject.Name,
                                      Salon = c.Room.Name
                                  })).ToListAsync();

            return response;
        }

    }
}
