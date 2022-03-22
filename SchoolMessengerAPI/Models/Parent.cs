namespace SchoolMessengerAPI.Models
{
    public class Parent : Person
    {
        public ICollection<Student> Students { get; set; }
        public string Description { get; set; }

    }
}
