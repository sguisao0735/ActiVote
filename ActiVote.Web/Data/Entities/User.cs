namespace ActiVote.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;
    

    public class User : IdentityUser
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

        [MaxLength(1, ErrorMessage = "The field {0} only supports {1} characters.")]
        public int Stratum { get; set; }

        [MaxLength(10, ErrorMessage = "The field {0} only supports {1} characters.")]
        public string Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
       

        public string City { get; set; }
                
    }
}
