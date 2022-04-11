using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDevelopment.Models
{
    public class Member
    {
        [Key]
        public int MemberNumber { get; set; }
        public int MembershipCategoryNumber { get; set; }
        [Required]
        public string MemberLastName { get; set; }
        [Required]
        public string MemberFirstName { get; set; }
        public string MemberEmail { get; set; }
        public DateTime MemberDOB { get; set; }
        
        [ForeignKey("MembershipCategoryNumber")]
        public MembershipCategory MemberCategory { get; set; }  

        public ICollection<Loan> Loan { get; set; }

    
    }
}
