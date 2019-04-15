namespace ActiVote.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Candidate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Proposal { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }


    }
}
