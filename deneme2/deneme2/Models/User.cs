using System.ComponentModel.DataAnnotations;

namespace deneme2.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public UserCategory UserDetails  { get; set; }

    }

}
