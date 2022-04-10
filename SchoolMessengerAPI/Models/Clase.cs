namespace SchoolMessengerAPI.Models
{
    /// <summary>
    /// Esta es la clase ej  MateI de 8 a 9 en el salon x
    /// </summary>
    public class Clase
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;

        // Nav propierties
        public List<Parcial> Parciales { get; set; }
        public Room Room { get; set; }
        public Subject Subject { get; set; }
        public List<ClaseStudent> ClaseStudents { get; set; }
    }
}
