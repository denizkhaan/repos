using deneme.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme.Pages.Login
{
    public class UserLoginModel : PageModel
    {
        public Model.User NewUser { get; set; }

        public ApplicationDbContext ContextDb { get; set; }

        public UserLoginModel(ApplicationDbContext context)
        {
            ContextDb = context;
            
        }
        public void OnGet()
        {

        }

        public void OnPost()
        {
        }
    }
}
