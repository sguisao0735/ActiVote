namespace ActiVote.Web.Models
{
    using System.ComponentModel.DataAnnotations;
    public class CandidateEventViewModel
    {
        public int EventId { get; set; }

        public int CandidateId { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only supports {1} characters.")]
        [Required]
        public string Name { get; set; }

        [MaxLength(250, ErrorMessage = "The field {0} only supports {1} characters.")]
        [Required]
        public string Proposal { get; set; }

    }
}
