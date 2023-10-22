using deneme.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace deneme.Pages.User
{
    public class UserListModel : PageModel
    {
        [BindProperty]
        public List<Model.User> _userlist { get; set; }
        public Model.User userlist { get; set; }

        public ApplicationDbContext _db { get; set; }

        public UserListModel(ApplicationDbContext db)
        {
            _db = db; 
        }
        public void OnGet()
        {
            

            userlist = new Model.User();
            _userlist = _db.Users.ToList();
            _userlist = _db.Users.Include(u => u.UserDetails).ToList();  //garip
        }

        public void OnPost()
        {

        }

    }
}
