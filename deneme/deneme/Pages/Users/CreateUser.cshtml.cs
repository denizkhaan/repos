using deneme.Data;
using deneme.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme.Pages.Users
{
    [BindProperties]
    public class CreateUserModel : PageModel
    {
        
        public Model.User NewUser { get; set; }
        
        public ApplicationDbContext Context { get; set; }
        //public IEnumerable<User> UserList { get; set; } //?
        public List<Users> DataList { get; set; }

        public CreateUserModel(ApplicationDbContext context)
        {
            Context = context;
            //ApplicationDbContext db =new ApplicationDbContext();
        }
        public void OnGet()
        {
            NewUser = new Model.User(); // cshtml model sayfasi mi oluyo
        }

        public void OnPost()
        {

            Context.Users.Add(NewUser);
            Context.SaveChanges();

        }

    }
}
