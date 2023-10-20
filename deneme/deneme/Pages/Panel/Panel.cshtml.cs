using deneme.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme.Pages.Panel
{
    public class PanelModel : PageModel
    {
        [BindProperty]
        public Model.User NewUser { get; set; }
        public ApplicationDbContext Context { get; set; }

        public PanelModel(ApplicationDbContext context) 
        {
            Context = context;  
        }
        public void OnGet()
        {
            NewUser = new Model.User();
        }

        public IActionResult OnPost(string UserName)
        {
            UserName = NewUser.Name;
            var user = Context.Users.FirstOrDefault(u => u.Name == UserName);
            if (user != null && user.IsAdmin == true)
            {
                return RedirectToPage("/User/DeleteUser"); // panel
            }
            else
            {
                return RedirectToPage("/User/CreateUser");
            }
        }
    }
}
