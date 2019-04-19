namespace ActiVote.Web.Models
{
    using System;
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

        //TODO: List of Cities
        public string City { get; set; }
    }

}
