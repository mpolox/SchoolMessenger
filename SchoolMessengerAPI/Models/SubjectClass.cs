namespace SchoolMessengerAPI.Models
{
    public class SubjectClass
    {
        public int Id { get; set; }
        public string Room { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; } = DateTime.MinValue;
        public DateTime dateTime { get; set; } = DateTime.MinValue;
    }
}
