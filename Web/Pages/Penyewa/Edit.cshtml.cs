using Infrastructure.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Pages.ViewModels;

namespace Web.Pages.Penyewa
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public EditModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty]
        public PenyewaViewModel Penyewa { get; set; } = default!;

        public IActionResult OnGet()
        {
            if (Id < 0) return RedirectToPage("/Penyewa/Index");
            var penyewa = context.Penyewa.FirstOrDefault(penyewa => penyewa.Id == Id);
            if (penyewa == null) return RedirectToPage("/Penyewa/Index");
            Penyewa = new PenyewaViewModel()
            {
                Id = penyewa.Id,
                NIK = penyewa.NIK,
                NamaLengkap = penyewa.NamaLengkap,
                JenisKelamin = penyewa.JenisKelamin,
                Domisili = penyewa.Domisili,
                Kota = penyewa.Kota,
                TempatLahir = penyewa.TempatLahir
            };
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var penyewaContext = context.Penyewa.FirstOrDefault(penyewa => penyewa.Id == Id);
                if (penyewaContext == null) return RedirectToPage("/Penyewa/Index");
                penyewaContext.Id = Penyewa.Id;
                penyewaContext.NIK = Penyewa.NIK;
                penyewaContext.NamaLengkap = Penyewa.NamaLengkap;
                penyewaContext.JenisKelamin = Penyewa.JenisKelamin;
                penyewaContext.Domisili = Penyewa.Domisili;
                penyewaContext.Kota = Penyewa.Kota;
                penyewaContext.TempatLahir = Penyewa.TempatLahir;
                context.Update(penyewaContext);
                context.SaveChanges();
            }
            return RedirectToPage("/Penyewa/Index");
        }
    }
}
