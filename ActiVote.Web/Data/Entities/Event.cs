﻿namespace ActiVote.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Event : IEntity
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only supports {1} characters.")]
        [Required]
        [Display(Name = "Event Name")]
        public string EventName { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only supports {1} characters.")]
        [Required]
        public string Description { get; set; }

        
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]

        public DateTime EndDate { get; set; }

        public User User { get; set; }

        public ICollection<Candidate> Candidates { get; set; }

        [Display(Name = "# Candidates")]
        public int NumberCandidates { get { return this.Candidates == null ? 0 : this.Candidates.Count; } }

    }
}
