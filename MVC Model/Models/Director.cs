using System;
using System.ComponentModel.DataAnnotations;



namespace MVC_Model.Models
{
    public class Director
    {
        [Display(Name = "label_identification", ResourceType = typeof(Resource))]
        public int ID { get; set; }

        [Display(Name = "label_name", ResourceType = typeof(Resource))]
        public string FirstName { get; set; }

        [Display(Name = "label_middle_name", ResourceType = typeof(Resource))]
        public string MiddleName { get; set; }

        [Display(Name = "label_last_name", ResourceType = typeof(Resource))]
        public string LastName { get; set; }

        [Display(Name = "label_email", ResourceType = typeof(Resource))]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "label_birthday", ResourceType = typeof(Resource))]
        public DateTime Birthday { get; set; }
    }
}