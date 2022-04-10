namespace SchoolMessengerAPI.Models
{
    public class ClaseStudent
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Clase Clase { get; set; }
        public Student Student { get; set; }
    }
}
