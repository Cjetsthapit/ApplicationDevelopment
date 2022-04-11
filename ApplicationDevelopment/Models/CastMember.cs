using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDevelopment.Models
{
    public class CastMember
    {
        [Key]
        public int Id { get; set; }
        public int DVDNumber { get; set; }
        
        public int ActorNumber { get; set; }

        [ForeignKey("DVDNumber")]
        public DVDTitle DVDTitle { get; set; }

        [ForeignKey("Actor Number")]
        public Actor Actor { get; set; }



    }
}
