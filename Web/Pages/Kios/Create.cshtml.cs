using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Pages.ViewModels;

namespace Web.Pages.Kios
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public KiosViewModel Kios { get; set; } = default!;

        public void OnPost()
        {

        }
    }
}
