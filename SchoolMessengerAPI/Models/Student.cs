namespace SchoolMessengerAPI.Models
{
    public class Student : Person
    {
        public string StudentId { get; set;}

        public ICollection<Parent> Parents { get; set; }

    }
}
