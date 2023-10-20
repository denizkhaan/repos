using deneme.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace deneme.Pages.User
{
    public class DeleteUserModel : PageModel
    {
        [BindProperty]
        public Model.User DeleteUser { get; set; }

        public ApplicationDbContext _db { get; set; }

        public List<Model.User> UserList { get; set; }

        public DeleteUserModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            DeleteUser = new Model.User();
            UserList = _db.Users.ToList();
        }
        public void OnPost(int userId)
        {
            userId = DeleteUser.Id;
            var findUserToRemove = _db.Users.Find(userId);
            if (findUserToRemove != null)
            {
                _db.Users.Remove(findUserToRemove);
                _db.SaveChanges();
            }
            
        }
       
    }
}
