using Domain.Entities;
using Infrastructure.Contexts;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Pages.ViewModels;

namespace Web.Pages.Penyewa
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public List<PenyewaViewModel> Penyewas { get; set; } = default!;

        public void OnGet()
        {
            var penyewaModels = new List<PenyewaViewModel>();
            var penyewas = context.Penyewa.ToList();
            foreach (var penyewa in penyewas)
            {
                var penyewaModel = new PenyewaViewModel()
                {
                    NIK = penyewa.NIK,
                    NamaLengkap = penyewa.NamaLengkap,
                    JenisKelamin = penyewa.JenisKelamin,
                    Domisili = penyewa.Domisili,
                    Kota = penyewa.Kota,
                    TempatLahir = penyewa.TempatLahir
                };
                penyewaModels.Add(penyewaModel);
            }
            Penyewas = penyewaModels;
        }
    }
}
