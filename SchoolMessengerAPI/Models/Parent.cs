namespace SchoolMessengerAPI.Models
{
    public class Parent : Person
    {
        public string Description { get; set; }

        // Navigation Properties
        public ICollection<ParentStudent>? ParentStudents { get; set; }

    }
}
