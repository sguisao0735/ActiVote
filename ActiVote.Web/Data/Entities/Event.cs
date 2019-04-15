namespace ActiVote.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Event
    {
        public int Id { get; set; }

        [Display(Name = "Event Name")]
        public string EventName { get; set; }

        public string Description { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

    }
}
