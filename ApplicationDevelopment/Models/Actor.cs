using System.ComponentModel.DataAnnotations;

namespace ApplicationDevelopment.Models
{
    public class Actor
    {
        [Key]
        public int ActorNumber { get; set; }
        [Required]
        public string ActorSurname { get; set; }
        [Required]
        public string ActorFirstName { get; set; }
        public ICollection<CastMember> CastMember { get; set; }
    }
}
