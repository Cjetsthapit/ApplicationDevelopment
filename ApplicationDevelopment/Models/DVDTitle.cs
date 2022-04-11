using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDevelopment.Models
{
    public class DVDTitle{
        [Key]
        public int DVDNumber { get; set; }   
        public int ProducerNumbermber { get; set; }   
        public int CategoryNumber { get; set; }   
        public int StudioNumber { get; set; }
        [Required]
        public DateTime DateReleased { get; set; }
        public double StandardCharge { get; set; }
        public double PenaltyCharge { get; set; }

        [ForeignKey("ProductNumber")]
        public Producer Producer { get; set; }
        [ForeignKey("CategoryNumber")]
        public DVDCategory DVDCategory { get; set; }
        [ForeignKey("StudioNumber")]
        public Studio Studio { get; set; }

        public ICollection<DVDCopy> DVDCopy { get; set; }   
        public ICollection<CastMember> CastMember { get; set; }

    }
}
