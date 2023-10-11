using deneme.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme.Pages.User
{
    public class UpdateUserModel : PageModel
    {
   
        [BindProperty]
        public Model.User UserForUpdate { get; set; }
        
        public ApplicationDbContext Context { get; set; }
        public UpdateUserModel(ApplicationDbContext context)
        {
            Context = context;
            //ApplicationDbContext db =new ApplicationDbContext();
        }
        public void OnGet()
        {

            UserForUpdate = new Model.User();
            
            //Dbcontext ile id'si parametredeki userId olan kullanıcıyı getirip UserForUpdate nesnesine ata
        }

        public PageResult OnPost(int userId)
        {
            userId = UserForUpdate.Id;

            var existingUser = Context.Users.Find(userId);
            if (existingUser != null) 
            {
                existingUser.Name = UserForUpdate.Name;
                existingUser.Email = UserForUpdate.Email;
                Context.SaveChanges();
                return Page();
            }
            else
            { return Page(); }




        }
    }
}
