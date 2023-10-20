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

        public ApplicationDbContext ContextDb { get; set; }

       public List<Model.User> DataList { get; set; }

        public CreateUserModel(ApplicationDbContext context)
        {
            ContextDb = context;
            //ApplicationDbContext db =new ApplicationDbContext();
        }
        public void OnGet()                                                                             
        {
            DataList = ContextDb.Users.ToList();
            NewUser = new Model.User();
        }

        public void OnPost()
        {
            try
            {
                ContextDb.Users.Add(NewUser);
                ContextDb.SaveChanges();
            }
            catch (Exception ex) { }

        }
    }
}
