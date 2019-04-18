namespace ActiVote.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Candidate : IEntity
    {
        public int Id { get; set; }

        [MaxLength(50,ErrorMessage = "The field {0} only supports {1} characters.")]
        [Required]
        public string Name { get; set; }

        [MaxLength(250, ErrorMessage = "The field {0} only supports {1} characters.")]
        [Required]
        public string Proposal { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        public User User { get; set; }

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImageUrl))
                {
                    return null;
                }

                return $"https://activote.azurewebsites.net{this.ImageUrl.Substring(1)}";
            }
        }
    }
}
