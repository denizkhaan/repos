using deneme2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace deneme2.Pages.User
{
    public class UserListModel : PageModel
    {
        [BindProperty]
        public Models.User Users { get; set; }

        //public List<Models.User> usertable {  get; set; } 

        public DbApplicationContext AppContext { get; set; }

        public UserListModel(DbApplicationContext context)

        {
            AppContext = context;
        }
        public void OnGet()
        {
            //usertable = AppContext.Users.ToList();
            Users = new Models.User();  
        }
        public void OnPost()
        {
            try
            {
                AppContext.Users.Add(Users);
                AppContext.SaveChanges();
            }
            catch (Exception ex) { }

        }
    }
}
