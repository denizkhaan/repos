using deneme.Data;
using deneme.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db; 

        public IEnumerable<Category> Categories { get; set; }
        public IndexModel(ApplicationDbContext db) 
        {
            _db = db; 
        }
        public void OnGet()
        {
            Categories = _db.Category; 
        }
    }
}
