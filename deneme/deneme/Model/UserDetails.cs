using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace deneme.Model
{
    public class UserDetails
    {
        [Key] 
        public int Id { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        //navigation property 
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
