using System.ComponentModel.DataAnnotations;

namespace ApplicationDevelopment.Models
{
    public class LoanTypes
    {
        [Key]
        public int LoanTypeNumber { get; set; }
        [Required]
        public string LoanType { get; set; }
        [Required]
        public string LoanDuration { get; set; }
        public ICollection<Loan> Loan { get; set; }
    }
}
