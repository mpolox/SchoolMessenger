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
                                   select ( new ClaseDto
                                   {
                                       Description = c.Description,
                                       Materia = c.Subject.Name,
                                       Salon = c.Room.Name
                                   })).ToListAsync();

            return null;
        }

        public async Task<IEnumerable<Clase>> GetClaseByCredit(int credits)
        {
            var response = await _context.Clases
                .Join(_context.Subjects, c => c.Subject.Id, s => s.Id, (c,s) => new {c,s})
                .Where(c => c.s.Credits == credits)
                .Select(c => new Clase
                {
                    Description = c.c.Description,
                    Parciales = c.c.Parciales
                })
                .ToListAsync();

            return response;
        }

        public Task<Clase> GetClaseById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Clase>> GetClaseByShortName(string shortName)
        {
            var response = await (from subject in _context.Subjects
                     join clase in _context.Clases
                     on subject.Id equals clase.Subject.Id
                     where subject.ShortName == shortName
                     select clase
                     ).ToListAsync();

            return response;
        }

        public async Task<IEnumerable<Clase>> GetClases()
        {
            var response = await _context.Clases.ToListAsync();
            return response;
        }

        public async Task<IEnumerable<Clase>> GetClasesByStudentId(int studentId)
        {
            var response = await (from cs in _context.ClaseStudents
                                  join c in _context.Clases
                                  on cs.Clase.Id equals c.Id
                                  join s in _context.Students
                                  on cs.Student.Id equals s.Id
                                  where s.Id == studentId
                                  select c).ToListAsync();
            return response;
        }

        public async Task<IEnumerable<Clase>> GetClasesByStudentMatricula(string matricula)
        {
            var response = await(from cs in _context.ClaseStudents
                                 join c in _context.Clases
                                 on cs.Clase.Id equals c.Id
                                 join s in _context.Students
                                 on cs.Student.Id equals s.Id
                                 where s.StudentId == matricula
                                 select c).ToListAsync();
            return response;
        }

        public async Task<IEnumerable<ClaseDtoR>> GetClasesByTeacherId(int id)
        {
            //var response = await(from cs in _context.ClaseStudents
            //                     join c in _context.Clases
            //                     on cs.Clase.Id equals c.Id
            //                     join s in _context.Students
            //                     on cs.Student.Id equals s.Id
            //                     where s.Id == id
            //                     select c).ToListAsync();
            return null;
        }

        public async Task<IEnumerable<Student>> GetClasesByX()
        {

            var response = await _context.Parciales
                .Join(_context.Students, par => par.StudentId, stud => stud.Id,
                (par, stud) => new { par, stud })
                .Join(_context.Clases, a => a.par.ClaseId, b => b.Id,
                (a, b) => new { a, b })
                .Where(q => q.b.Description == "Mate 1")
                .Select(sel => new Student
                {
                    FirstName = sel.a.stud.FirstName
                }).Distinct().ToListAsync();
                

            return null;
        }

    }
}
