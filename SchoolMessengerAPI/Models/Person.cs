using System.ComponentModel.DataAnnotations;

namespace SchoolMessengerAPI.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string ParentName { get; set; }

        public string MotherName { get; set; } = "Person's Mothername";

        public DateTime Birthday { get; set; } = DateTime.UtcNow;
        
        public string Curp { get; set; } = "Person's CURP";

        [Required]
        public string Email { get; set; }

        [MaxLength(25)]
        public string CellPhone { get; set; } = "Person's Cellphone";

        [MaxLength(25)]
        public string Phone { get; set; } = "Person's Phone";

        public string Address { get; set; } = "Person's Address";

    }
}
