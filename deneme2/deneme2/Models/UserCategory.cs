using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace deneme2.Models
{
    public class UserCategory
    {
        [Key] // This is the primary key for UserCategory
        public int Id { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        // Define a navigation property back to the User entity
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
