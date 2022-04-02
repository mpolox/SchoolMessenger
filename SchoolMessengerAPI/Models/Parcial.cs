namespace SchoolMessengerAPI.Models
{
    public class Parcial
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public float Grade { get; set; } = 0;
        public int Absence { get; set; } = 0;
        public string Comments { get; set; } = string.Empty;

        // Navigational Properties
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ClaseId { get; set; }
        public Clase Clases { get; set; }

    }
}
