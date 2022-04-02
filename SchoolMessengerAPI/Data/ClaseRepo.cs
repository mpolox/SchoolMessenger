using Microsoft.EntityFrameworkCore;
using SchoolMessengerAPI.Data.Interfaces;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public class ClaseRepo : IClasesRepo

    {
        private readonly SchoolContext _context;

        public ClaseRepo(SchoolContext  context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Clase>> GetClases()
        {
            var response = await _context.Clases.ToListAsync();
            return response;
        }

        public async Task<IEnumerable<Student>> GetClasesByX()
        {
            //var myResponse =  await _context.Parciales
            //    .Join(_context.Students,   p => p.StudentId,     s => s.Id, (p, s) => new { p, s })
            //    .Join(_context.Clases, f => f.p.ClaseId, c => c.Id, (f, c) => new { f, c })
            //    .Where( v => v.c.Description == "Mate 1")
            //    .Select(m => new Student
            //    { 
            //        FirstName  = m.f.s.FirstName,
            //        ParentName = m.f.s.ParentName,
            //        Address = String.Empty,
            //        Birthday = m.f.s.Birthday,
            //        CellPhone = String.Empty,
            //        Curp = String.Empty,
            //        Email = String.Empty,
            //        MotherName =String.Empty,
            //        Phone = String.Empty,
            //    }).Distinct().ToListAsync();
            //return myResponse;
            return null;
        }

    }
}
