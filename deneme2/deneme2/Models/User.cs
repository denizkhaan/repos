using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace deneme2.Models
{
    public class User
    {
        [Key] // This is the primary key for User
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        // Define a foreign key relationship to UserCategory
        [ForeignKey("UserCategory")]
        public int UserCategoryId { get; set; }
        public UserCategory UserDetails { get; set; }
    }
}
