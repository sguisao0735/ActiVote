namespace ActiVote.Web.Models
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ChangeUserViewModel
    {
        [MaxLength(50, ErrorMessage = "The field {0} only supports {1} characters.")]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only supports {1} characters.")]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only supports {1} characters.")]
        public string Occupation { get; set; }

        [Range(1, 9, ErrorMessage = "The field {0} only allows values ​​between 1 and 9")]
        public int Stratum { get; set; }

        //TODO: List of Genders
        [MaxLength(10, ErrorMessage = "The field {0} only supports {1} characters.")]
        public string Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }


        [Display(Name = "City")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a city.")]
        public int CityId { get; set; }

        public IEnumerable<SelectListItem> Cities { get; set; }

        [Display(Name = "Country")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a country.")]
        public int CountryId { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

    }

}
