using Domain.Entities;
using Infrastructure.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Pages.ViewModels;

namespace Web.Pages.Penyewa
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public CreateModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        [BindProperty]
        public PenyewaViewModel Penyewa { get; set; } = default!;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var penyewa = new Domain.Entities.Penyewa()
                {
                    NIK = Penyewa.NIK,
                    NamaLengkap = Penyewa.NamaLengkap,
                    JenisKelamin = Penyewa.JenisKelamin,
                    Domisili = Penyewa.Domisili,
                    Kota = Penyewa.Kota,
                    TempatLahir = Penyewa.TempatLahir
                };
                context.Add(penyewa);
                context.SaveChanges();
                return RedirectToPage("/Penyewa/Index");
            }
            return Page();
        }
    }
}
