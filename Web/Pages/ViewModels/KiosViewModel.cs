using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Web.Pages.ViewModels
{
    public class KiosViewModel
    {
        public long Id { get; set; }
        [Required]
        public string? Label { get; set; }
        [Required]
        public TipeKios Tipe { get; set; }
        [Required]
        public string? Luas { get; set; }
        [Required]
        public int Lantai { get; set; }
        [Required]
        public decimal Harga { get; set; }
    }
}
