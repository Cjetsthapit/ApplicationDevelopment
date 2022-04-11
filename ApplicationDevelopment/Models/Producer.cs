using System.ComponentModel.DataAnnotations;

namespace ApplicationDevelopment.Models
{
    public class Producer
    {
        [Key]
        public int ProducerNumber { get; set; }
        [Required]
        public string ProducerName { get; set; }
        public ICollection<DVDTitle> DVDTitle { get; set; }

    }
}
