using deneme.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace deneme.Pages.User
{
    public class deleteUserModel : PageModel
    {
        [BindProperty]
        public Model.User DeleteUser { get; set; }

        public ApplicationDbContext _db { get; set; }

        public deleteUserModel(ApplicationDbContext db)
        {
            _db = db;
        }
       
        public void OnPost1(int userId)
        {
            userId = DeleteUser.Id;
            var findUserToRemove = _db.Users.Find(userId);
            if (findUserToRemove != null)
            {
                _db.Users.Remove(findUserToRemove);
                _db.SaveChanges();
            }
            
        }
        public void OnPost2()
        {
            foreach(var user in _db.Users)
            {
                _db.Users.Remove(user);             // CALISMIYOR
            }
            _db.SaveChanges();
        }
    }
}
