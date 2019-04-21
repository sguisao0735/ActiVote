namespace ActiVote.Web.Models
{
    using System.ComponentModel.DataAnnotations;
    using Data.Entities;
    using Microsoft.AspNetCore.Http;

    public class CandidateViewModel : Candidate
    {
        public int EventId { get; set; }

        public int CandidateId { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only supports {1} characters.")]
        [Required]
        public new string Name { get; set; }

        [MaxLength(250, ErrorMessage = "The field {0} only supports {1} characters.")]
        [Required]
        public new string Proposal { get; set; }

        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

    }
}
