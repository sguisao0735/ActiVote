namespace ActiVote.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class RegisterNewUserViewModel
    {
        [MaxLength(50, ErrorMessage = "The field {0} only supports {1} characters.")]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only supports {1} characters.")]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} only supports {1} characters.")]
        public string Occupation { get; set; }

        [Required]
        [Range(1, 9, ErrorMessage = "The field {0} only allows values ​​between 1 and 9")]
        public int Stratum { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "The field {0} only supports {1} characters.")]
        public string Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        //TODO: validate if it must be Required
        public string City { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string Confirm { get; set; }
    }

}
