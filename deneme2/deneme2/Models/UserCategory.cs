using System.ComponentModel.DataAnnotations.Schema;

namespace deneme2.Models
{
    public class UserCategory
    {
        [ForeignKey("User")]
        public int Id { get; set; }
        public string Phone { get; set; }

        public string Adress { get; set; }

    }
}
