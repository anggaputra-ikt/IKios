using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Penyewa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        public string? NIK { get; set; }
        public string? NamaLengkap { get; set; }
        public JenisKelamin? JenisKelamin { get; set; }
        public string? Domisili { get; set; }
        public string? Kota { get; set; }
        public string? TempatLahir { get; set; }
    }

    public enum JenisKelamin
    {
        [Display(Name = "Laki Laki")]
        LakiLaki,
        Perempuan
    }
}
