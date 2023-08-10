using Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Pages.ViewModels
{
    public class PenyewaViewModel
    {
        public long Id { get; set; }
        [Required]
        public string? NIK { get; set; }
        [Required, DisplayName("Nama Lengkap")]
        public string? NamaLengkap { get; set; }
        [Required, DisplayName("Jenis Kelamin")]
        public JenisKelamin? JenisKelamin { get; set; }
        [Required]
        public string? Domisili { get; set; }
        [Required]
        public string? Kota { get; set; }
        [Required, DisplayName("Tempat Lahir")]
        public string? TempatLahir { get; set; }
    }
}
