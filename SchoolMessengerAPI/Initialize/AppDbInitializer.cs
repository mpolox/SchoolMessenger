using SchoolMessengerAPI.Data;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Initialize
{
    public class AppDbInitializer
    {
       
        public static void Seed(IApplicationBuilder ab)
        {
            List<Room> myRooms = new List<Room>
            {
                new Room() { Name = "Salón 01", Number = 1 },
                new Room() { Name = "Salón 02", Number = 2 },
                new Room() { Name = "Salón 03", Number = 3 },
                new Room() { Name = "Salón 04", Number = 4 },
                new Room() { Name = "Salón 05", Number = 5 },
                new Room() { Name = "Salón 06", Number = 6 },
                new Room() { Name = "Salón 07", Number = 7 },
                new Room() { Name = "Salón 08", Number = 8 }
            };

            List<Subject> mySubjects = new List<Subject>
            {
                new Subject() { Credits = 10, ShortName = "TLR I", Name = "Taller de lectura y redacción I", Description = "Descripción Materia 1" },
                new Subject() { Credits = 10, ShortName = "TLR II", Name = "Taller de lectura y redacción II", Description = "Descripción Materia 2"},
                new Subject() { Credits = 10, ShortName = "Mate I", Name = "Matemáticas I", Description = "Descripción Materia 3"},
                new Subject() { Credits = 10, ShortName = "Mate II", Name = "Matemáticas II", Description = "Descripción Materia 4"},
                new Subject() { Credits = 10, ShortName = "Mate III", Name = "Matemáticas III", Description = "Descripción Materia 5"},
                new Subject() { Credits = 5, ShortName = "Artes", Name = "Historia del Arte", Description = "Descripción Materia 6"},
                new Subject() { Credits = 5, ShortName = "Civismo", Name = "Civismo", Description = "Descripción Materia 7"},
                new Subject() { Credits = 5, ShortName = "Deportes", Name = "Deportes", Description = "Descripción Materia 8"},
                new Subject() { Credits = 10, ShortName = "Física I", Name = "Física I", Description = "Descripción Materia 9"},
                new Subject() { Credits = 10, ShortName = "Física II", Name = "Física II", Description = "Descripción Materia 10"},
            };

            List<Teacher> myTeachers = new List<Teacher>()
            {
                new Teacher() {Email = "teacer01@gmail.com", FirstName = "Teacher Name 01", ParentName = "Apellido 01",  Code="T001"},
                new Teacher() {Email = "teacer02@gmail.com", FirstName = "Teacher Name 02", ParentName = "Apellido 02",  Code="T002"},
                new Teacher() {Email = "teacer03@gmail.com", FirstName = "Teacher Name 03", ParentName = "Apellido 03",  Code="T003"},
                new Teacher() {Email = "teacer04@gmail.com", FirstName = "Teacher Name 04", ParentName = "Apellido 04",  Code="T004"},
                new Teacher() {Email = "teacer05@gmail.com", FirstName = "Teacher Name 05", ParentName = "Apellido 05",  Code="T005"},
                new Teacher() {Email = "teacer06@gmail.com", FirstName = "Teacher Name 06", ParentName = "Apellido 06",  Code="T006"},
                new Teacher() {Email = "teacer07@gmail.com", FirstName = "Teacher Name 07", ParentName = "Apellido 07",  Code="T007"},
                new Teacher() {Email = "teacer08@gmail.com", FirstName = "Teacher Name 08", ParentName = "Apellido 08",  Code="T008"},
                new Teacher() {Email = "teacer09@gmail.com", FirstName = "Teacher Name 09", ParentName = "Apellido 09",  Code="T009"},
                new Teacher() {Email = "teacer10@gmail.com", FirstName = "Teacher Name 10", ParentName = "Apellido 10",  Code="T010"}
            };

            using var serviceScope = ab.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<SchoolContext>();

            if (context is not null)
            {
                if (!context.Rooms.Any())
                {
                    context.Rooms.AddRange(myRooms);
                    context.SaveChanges();
                }
                if (!context.Subjects.Any())
                {
                    context.Subjects.AddRange(mySubjects);
                    context.SaveChanges();
                }
                if (!context.Teachers.Any())
                {
                    context.Teachers.AddRange(myTeachers);
                    context.SaveChanges();
                }
            }
        }
    }
}
