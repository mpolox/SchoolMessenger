using SchoolMessengerAPI.Data;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Initialize
{
    public class AppDbInitializer
    {
       
        public static void Seed(IApplicationBuilder ab)
        {
            using var serviceScope = ab.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<SchoolContext>();

            if (context is not null)
            {
                if (!context.Rooms.Any())
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

                    context.Rooms.AddRange(myRooms);
                    context.SaveChanges();
                }
                if (!context.Subjects.Any())
                {
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

                    context.Subjects.AddRange(mySubjects);
                    context.SaveChanges();
                }
                if (!context.Teachers.Any())
                {
                    List<Teacher> myTeachers = new List<Teacher>()
                    {
                        new Teacher() {Email = "teacher01@gmail.com", FirstName = "Teacher Name 01", ParentName = "Apellido 01",  Code="T001"},
                        new Teacher() {Email = "teacher02@gmail.com", FirstName = "Teacher Name 02", ParentName = "Apellido 02",  Code="T002"},
                        new Teacher() {Email = "teacher03@gmail.com", FirstName = "Teacher Name 03", ParentName = "Apellido 03",  Code="T003"},
                        new Teacher() {Email = "teacher04@gmail.com", FirstName = "Teacher Name 04", ParentName = "Apellido 04",  Code="T004"},
                        new Teacher() {Email = "teacher05@gmail.com", FirstName = "Teacher Name 05", ParentName = "Apellido 05",  Code="T005"},
                        new Teacher() {Email = "teacher06@gmail.com", FirstName = "Teacher Name 06", ParentName = "Apellido 06",  Code="T006"},
                        new Teacher() {Email = "teacher07@gmail.com", FirstName = "Teacher Name 07", ParentName = "Apellido 07",  Code="T007"},
                        new Teacher() {Email = "teacher08@gmail.com", FirstName = "Teacher Name 08", ParentName = "Apellido 08",  Code="T008"},
                        new Teacher() {Email = "teacher09@gmail.com", FirstName = "Teacher Name 09", ParentName = "Apellido 09",  Code="T009"},
                        new Teacher() {Email = "teacher10@gmail.com", FirstName = "Teacher Name 10", ParentName = "Apellido 10",  Code="T010"}
                    };

                    context.Teachers.AddRange(myTeachers);
                    context.SaveChanges();
                }
                if (!context.Parents.Any())
                {
                    List<Parent> myParents = new List<Parent>()
                    {
                        new Parent() {Email = "Parent01@gmail.com", FirstName="Parent01", ParentName="Apellido01", Description = "Descripción 01"},
                        new Parent() {Email = "Parent02@gmail.com", FirstName="Parent02", ParentName="Apellido02", Description = "Descripción 02"},
                        new Parent() {Email = "Parent03@gmail.com", FirstName="Parent03", ParentName="Apellido03", Description = "Descripción 03"},
                        new Parent() {Email = "Parent04@gmail.com", FirstName="Parent04", ParentName="Apellido04", Description = "Descripción 04"},
                        new Parent() {Email = "Parent05@gmail.com", FirstName="Parent05", ParentName="Apellido05", Description = "Descripción 05"},
                        new Parent() {Email = "Parent06@gmail.com", FirstName="Parent06", ParentName="Apellido06", Description = "Descripción 06"},
                        new Parent() {Email = "Parent07@gmail.com", FirstName="Parent07", ParentName="Apellido07", Description = "Descripción 07"},
                        new Parent() {Email = "Parent08@gmail.com", FirstName="Parent08", ParentName="Apellido08", Description = "Descripción 08"},
                        new Parent() {Email = "Parent09@gmail.com", FirstName="Parent09", ParentName="Apellido09", Description = "Descripción 09"},
                        new Parent() {Email = "Parent10@gmail.com", FirstName="Parent10", ParentName="Apellido10", Description = "Descripción 10"}
                    };

                    context.Parents.AddRange(myParents);
                    context.SaveChanges();
                }
                if (!context.Students.Any())
                {
                    List<Student> myStudents = new List<Student>()
                    {
                        new Student() {StudentId = "CODE001", Email = "student01@gmail.com", FirstName = "Student01", ParentName = "Apellido01", Details = "Detalles del estudiante"},
                        new Student() {StudentId = "CODE002", Email = "student02@gmail.com", FirstName = "Student02", ParentName = "Apellido02", Details = "Detalles del estudiante"},
                        new Student() {StudentId = "CODE003", Email = "student03@gmail.com", FirstName = "Student03", ParentName = "Apellido03", Details = "Detalles del estudiante"},
                        new Student() {StudentId = "CODE004", Email = "student04@gmail.com", FirstName = "Student04", ParentName = "Apellido04", Details = "Detalles del estudiante"},
                        new Student() {StudentId = "CODE005", Email = "student05@gmail.com", FirstName = "Student05", ParentName = "Apellido05", Details = "Detalles del estudiante"},
                        new Student() {StudentId = "CODE006", Email = "student06@gmail.com", FirstName = "Student06", ParentName = "Apellido06", Details = "Detalles del estudiante"},
                        new Student() {StudentId = "CODE007", Email = "student07@gmail.com", FirstName = "Student07", ParentName = "Apellido07", Details = "Detalles del estudiante"},
                        new Student() {StudentId = "CODE008", Email = "student08@gmail.com", FirstName = "Student08", ParentName = "Apellido08", Details = "Detalles del estudiante"},
                        new Student() {StudentId = "CODE009", Email = "student09@gmail.com", FirstName = "Student09", ParentName = "Apellido09", Details = "Detalles del estudiante"},
                        new Student() {StudentId = "CODE010", Email = "student10@gmail.com", FirstName = "Student10", ParentName = "Apellido10", Details = "Detalles del estudiante"}
                    };

                    context.Students.AddRange(myStudents);
                    context.SaveChanges();
                }
                if (!context.ParentStudents.Any())
                {
                    var s1 = context.Students.ToList();
                    var p1 = context.Parents.ToList();

                    List<ParentStudent> myParentStudents = new List<ParentStudent>()
                    {
                        new ParentStudent() { Parent = p1[0], Student = s1[0]},
                        new ParentStudent() { Parent = p1[1], Student = s1[1]},
                        new ParentStudent() { Parent = p1[2], Student = s1[2]},
                        new ParentStudent() { Parent = p1[3], Student = s1[3]},
                        new ParentStudent() { Parent = p1[4], Student = s1[4]},
                        new ParentStudent() { Parent = p1[5], Student = s1[5]},
                        new ParentStudent() { Parent = p1[6], Student = s1[6]},
                        new ParentStudent() { Parent = p1[7], Student = s1[7]},
                        new ParentStudent() { Parent = p1[8], Student = s1[8]},
                        new ParentStudent() { Parent = p1[9], Student = s1[9]}
                        
                    };

                    context.ParentStudents.AddRange(myParentStudents);
                    context.SaveChanges();
                }


            }
        }
    }
}
