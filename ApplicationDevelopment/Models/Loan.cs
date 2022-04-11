using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDevelopment.Models
{
    public class Loan
    {
        [Key]
        public int LoanNumber { get; set; } 
        public int LoanTypeNumber { get; set; }
        public int CopyNumber { get; set; }
        public int MemberNumber { get; set; }
        [Required]
        public DateTime DateOut { get; set; }
        [Required]
        public DateTime DateDue { get; set; }
        [Required]
        public DateTime DateReturned { get; set; }
        [ForeignKey("LoanTypeNumber")]
        public LoanTypes LoanTypes { get; set; }
        [ForeignKey("CopyNumber")]
        public DVDCopy DVDCopy { get; set; }
        [ForeignKey("MemberNumber")]
        public Member Member { get; set; }
    }
}
