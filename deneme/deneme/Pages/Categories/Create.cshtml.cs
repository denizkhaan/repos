using deneme.Data;
using deneme.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deneme.Pages.Categories;

[BindProperties]
    public class CreateModel : PageModel
    {
        public readonly ApplicationDbContext _db;

        public Category Category { get; set; } 

        public CreateModel(ApplicationDbContext db) 
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            await _db.Category.AddAsync(Category);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }

