using System.ComponentModel.DataAnnotations;

namespace ApplicationDevelopment.Models
{
    public class Studio
    {
        [Key]
        public int StudioNumber { get; set; }
        [Required]
        public string StudioName { get; set; }
        public ICollection<DVDTitle> DVDTitle { get; set; }

    }
}
