namespace SchoolMessengerAPI.Models
{
    /// <summary>
    /// Esta es la clase ej  Mate I de 8 a 9 en el salon x
    /// </summary>
    public class Clase
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;

        // Nav propierties
        public List<Parcial> Parciales { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public List<ClaseStudent> ClaseStudents { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
    }
}
