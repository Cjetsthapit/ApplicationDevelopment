using System.ComponentModel.DataAnnotations;

namespace ApplicationDevelopment.Models
{
    public class MembershipCategory
    {

        [Key]
        public int MembershipCategoryNumber { get; set; }
        [Required]
        public string MermbershipCategoryDescription { get; set; }
        [Required]
        public string MermbershipCategoryTotalLoans { get; set; }

        public ICollection<Member> Member { get; set; }   
    }
}
