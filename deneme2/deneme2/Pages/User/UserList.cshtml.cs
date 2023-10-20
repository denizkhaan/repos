using deneme2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace deneme2.Pages.User
{
    public class UserListModel : PageModel
    {
        public Models.User Users { get; set; }

        public DbApplicationContext AppContext { get; set; }

        UserListModel(DbApplicationContext context)
        {
            AppContext = context;
        }
        public void OnGet()
        {
            Users = new Models.User();  
        }
    }
}
