namespace SchoolMessengerAPI.Models
{
    public class Student : Person
    {
        public string StudentId { get; set;}


        // Navigation Properties
        public ICollection<ParentStudent>? ParentStudents { get; set; }

    }
}
