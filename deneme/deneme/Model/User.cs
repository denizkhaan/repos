using System.ComponentModel.DataAnnotations;
namespace deneme.Model

{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Email { get; set; }

       // public Category UserCategory { get; set; }
    }
}
