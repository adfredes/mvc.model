using System;



namespace MVC_Model.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }
    }
}