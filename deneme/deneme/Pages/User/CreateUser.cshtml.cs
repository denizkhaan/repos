using deneme.Data;
using deneme.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme.Pages.User
{
    
    public class CreateUserModel : PageModel
    {
        [BindProperty]
        public Model.User NewUser { get; set; }
        [BindProperty]
        public Model.UserDetails UserDetails { get; set; }

        public ApplicationDbContext ContextDb { get; set; }

        public List<Model.User> DataList { get; set; }

        public CreateUserModel(ApplicationDbContext context)
        {
            ContextDb = context;
            //ApplicationDbContext db =new ApplicationDbContext();
        }
        public void OnGet()                                                                             
        {
            //DataList = new List<Model.User>();
            DataList = ContextDb.Users.ToList();
            NewUser = new Model.User();
            UserDetails = new Model.UserDetails();
            
        }

        public void OnPost()
        {
            try
            {
                ContextDb.Users.Add(NewUser);
                NewUser.UserDetails = UserDetails;
                ContextDb.Details.Add(UserDetails);
                ContextDb.SaveChanges();
            }
            catch (Exception ex) { }

        }
    }
}
