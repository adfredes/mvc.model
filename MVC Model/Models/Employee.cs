using System;
using System.ComponentModel.DataAnnotations;



namespace MVC_Model.Models
{
    public class Employee
    {
        [Display(Name = "Identification")]
        public int ID { get; set; }

        [Display(Name = "Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle")]
        public string MiddleName { get; set; }

        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }
    }
}