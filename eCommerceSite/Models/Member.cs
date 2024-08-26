using System.ComponentModel.DataAnnotations;

namespace eCommerceSite.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Phone { get; set; }

        public string Username { get; set; }
    }
}
