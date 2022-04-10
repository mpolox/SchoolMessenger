using Microsoft.EntityFrameworkCore;
using SchoolMessengerAPI.Data.Interfaces;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Data
{
    public class ClaseRepo : IClasesRepo

    {
        private readonly SchoolContext _context;

        public ClaseRepo()
        {
        }

        public ClaseRepo(SchoolContext  context)
        {
            _context = context;
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
            string name = "Marcopolo";

            var response = await (from cs in _context.ClaseStudents
                                  join c in _context.Clases
                                  on cs.Clase.Id equals c.Id
                                  join s in _context.Students
                                  on cs.Student.Id equals s.Id
                                  where s.FirstName == name
                                  select c).ToListAsync();

            //var response =  await (from parcial in _context.Parciales
            //                     join clase in _context.Clases
            //                     on parcial.ClaseId equals clase.Id
            //                     join student in _context.Students
            //                     on parcial.StudentId equals student.Id
            //                     where student.FirstName == name
            //                     select clase).ToListAsync();

            return response;
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
                

            //var query = context.Customers
            //    .Join(
            //        context.Invoices,
            //        customer => customer.CustomerId,
            //        invoice => invoice.Customer.CustomerId,
            //        (customer, invoice) => new
            //        {
            //            InvoiceID = invoice.Id,
            //            CustomerName = customer.FirstName + "" + customer.LastName,
            //            InvoiceDate = invoice.Date
            //        }
            //    ).ToList();

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
