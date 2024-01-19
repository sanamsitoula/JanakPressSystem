using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Temp.Data;
using Razor_Temp.Models;

namespace Razor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public List<Category> CategoryList { get; set; }
        public IndexModel(ApplicationDBContext db)
        {
            _db = db;

        }
        public void OnGet()
        {
           // CategoryList= _db.Categories.ToList();
            CategoryList = _db.Categories.Where(e => e.Status == true).ToList();

        }
    }
}
