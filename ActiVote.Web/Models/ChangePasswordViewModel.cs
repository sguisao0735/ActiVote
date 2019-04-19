namespace ActiVote.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ChangePasswordViewModel
    {
        [MinLength(6)]
        [Required]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [MinLength(6)]
        [Required]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [MinLength(6)]
        [Required]
        [Compare("NewPassword")]
        public string Confirm { get; set; }
    }

}
