﻿namespace SchoolMessengerAPI.Models
{
    public class Student : Person
    {
        public string StudentId { get; set;}

        public string StudentName { get; set;}

        // Navigation Properties
        public ICollection<ParentStudent>? ParentStudents { get; set; }

        public List<Parcial> Parciales { get; set; }
    }
}
