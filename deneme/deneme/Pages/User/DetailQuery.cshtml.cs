using deneme.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme.Pages.User
{
    public class DetailQueryModel : PageModel
    {
        [BindProperty]
        public Model.User NewUser { get; set; }
        [BindProperty]
        public Model.UserDetails User1 { get; set; }
        [BindProperty]
        public int UserInputID { get; set; }
        //public List<Model.UserDetails> _userdetail { get; set; }
        public ApplicationDbContext _db { get; set; }


        public DetailQueryModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            User1 = new Model.UserDetails();
        }

        public void OnPost()
        {
            User1 = _db.Details.Find(UserInputID);
      
        }
        
        
            
    }
}
