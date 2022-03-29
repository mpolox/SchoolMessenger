using System.ComponentModel.DataAnnotations;

namespace SchoolMessengerAPI.Models
{
    /// <summary>
    /// Esta es la Materia (ie. Español, Ingles, TLR...)
    /// </summary>
    public class Subject
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        public string Description { get; set; } = "";
        public int Credits { get; set; } = 8;

        [Required]
        [MaxLength(10)]
        public string ShortName { get; set; }
    }
}
