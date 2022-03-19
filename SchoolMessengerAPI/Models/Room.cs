using System.ComponentModel.DataAnnotations;

namespace SchoolMessengerAPI.Models
{
    public class Room
    {
        [Required]
        public int Id { get; set; }

        public int Number { get; set; }

        [Required]
        [MaxLength(10)]
        public string Name { get; set; } = "";
    }
}
