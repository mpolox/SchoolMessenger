namespace SchoolMessengerAPI.Models
{
    /// <summary>
    /// Esta es la Materia (ie. Español, Ingles, TLR...)
    /// </summary>
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = "";
        public int Credits { get; set; }
    }
}
