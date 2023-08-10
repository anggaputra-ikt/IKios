namespace Domain.Entities
{
    public class Kios
    {
        public long Id { get; set; }
        public string? Label { get; set; }
        public TipeKios Tipe { get; set; }
        public string? Luas { get; set; }
        public int Lantai { get; set; }
        public decimal Harga { get; set; }
    }

    public enum TipeKios
    {
        A,
        B,
        C
    }
}
