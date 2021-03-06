using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ApplicationDevelopment.Models
{
    public class User : IdentityUser
    {
        [Key]
        public int UserNumber { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserType { get; set; }
        [Required]
        public string UserPassword { get; set; }
    }
}
