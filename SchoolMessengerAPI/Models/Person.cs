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

        public string MotherName { get; set; }

        public DateTime Birthday { get; set; } = DateTime.MinValue;
        
        public string Curp { get; set; } = "";

        [Required]
        public string Email { get; set; }

        public string CellPhone { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

    }
}
