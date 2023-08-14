using Domain.Entities;
using Infrastructure.Contexts;
using Microsoft.AspNetCore.Mvc;
using Web.Pages.ViewModels;

namespace Web.Controllers
{
    public class PenyewaController : Controller
    {
        private readonly ApplicationDbContext context;

        public PenyewaController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [FromForm]
        public PenyewaViewModel Penyewa { get; set; } = default!;

        [HttpPost]
        public IActionResult CreatePost()
        {
            if(ModelState.IsValid)
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
            return RedirectToPage("/Penyewa/Create");
        }
    }
}
