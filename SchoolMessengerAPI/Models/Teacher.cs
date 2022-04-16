namespace SchoolMessengerAPI.Models
{
    public class Teacher: Person
    {
        public string Code { get; set; } = "Teacher's code";
        public string Description { get; set; } = "Description of Teacher";
        public List<Clase> Clases { get; set; }


    }
}
