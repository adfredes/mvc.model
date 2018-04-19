using System.ComponentModel.DataAnnotations;



namespace MVC_Model.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Display(Name= "label_street",  ResourceType=typeof(Resource))]
        [Required(AllowEmptyStrings=false, ErrorMessageResourceName= "err_address_street",  ErrorMessageResourceType=typeof(Resource))]
        public string Street { get; set; }

        [Display(Name = "label_locality", ResourceType = typeof(Resource))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "err_locality_street", ErrorMessageResourceType = typeof(Resource))]
        public string Locality { get; set; }

        [Display(Name = "label_country", ResourceType = typeof(Resource))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "err_country_street", ErrorMessageResourceType = typeof(Resource))]
        public string Country { get; set; }

        [Display(Name = "label_state", ResourceType = typeof(Resource))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "err_state_street", ErrorMessageResourceType = typeof(Resource))]
        public string State { get; set; }

        [Display(Name = "label_zip", ResourceType = typeof(Resource))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "err_zip_street", ErrorMessageResourceType = typeof(Resource))]
        public string Zip { get; set; }
    }
}