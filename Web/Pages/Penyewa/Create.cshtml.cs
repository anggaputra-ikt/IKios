using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Pages.ViewModels;

namespace Web.Pages.Penyewa
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public PenyewaViewModel Penyewa { get; set; } = default!;

        public void OnGet()
        {
        }
    }
}
