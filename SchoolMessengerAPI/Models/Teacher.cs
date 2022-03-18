namespace SchoolMessengerAPI.Models
{
    public class Teacher: Person
    {
        public string Code { get; set; } = "";

        public string Description { get; set; } = "";

        public IEnumerable<Subject> Subject { get; set; } = Enumerable.Empty<Subject>();

    }
}
