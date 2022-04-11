using System.ComponentModel.DataAnnotations;

namespace ApplicationDevelopment.Models
{
    public class DVDCategory
    {
        [Key]
        public int CategoryNumber { get; set; }
        [Required]
        public string CategoryDescription { get; set; }
        [Required]
        public bool AgeRestricted { get; set; }

        public ICollection<DVDTitle> DVDTitle { get; set; } 
    }
}
