using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Penyewa
{
    public class EditModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public IActionResult OnGet()
        {
            if (Id <= 0)
            {
                return RedirectToPage("/Penyewa/Index");
            }
            return Page();
        }
    }
}
