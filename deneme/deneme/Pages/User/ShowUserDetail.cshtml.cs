using deneme.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme.Pages.User
{
    public class ShowUserDetailModel : PageModel
    {
        [BindProperty]
        public Model.User DeleteUser { get; set; }

        public ApplicationDbContext _db { get; set; }

        public ShowUserDetailModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}
