using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace MVC_Model.Models
{
	public class Person
	{
		public string Id { get; set; }

		[Required]
		[Display(Name = "First Name", Order = 2)]
		public string FirstName { get; set; }

		[Required(ErrorMessage="Your {0} is required")]
		[StringLength(60,MinimumLength =4,ErrorMessage ="{0} should be between 4 to 60 Char")]
		[Display(Name="Last Name",Order =1)]
		public string LastName { get; set; }

		public DateTime DateOfBirth { get; set; }

		[ScaffoldColumn(false)]
		public string Address { get; set; }

		[ReadOnly(true)]
		public Decimal Income { get; set; }

		public string ContactNo { get; set; }

		[RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Invalid Email Id")]
		public string EmailId { get; set; }

		[Compare("EmailId")]
		public string ConfirmEmail { get; set; }

		public string UserName { get; set; }

		[DataType(DataType.Password)]
		public string  Password { get; set; }
	}
}