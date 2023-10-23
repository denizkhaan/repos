using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace deneme.Model

{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }


        [ForeignKey("UserCategory")]
        public int UserCategoryId { get; set; }
        public UserDetails UserDetails { get; set; }


        public ICollection<UserRole> UserRoles { get; set; }

    }
}
