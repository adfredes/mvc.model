using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace MVC_Model.Models
{
	public class Person2
	{
		
        [Required]
        public string FirstName { get; set; }
	}
}