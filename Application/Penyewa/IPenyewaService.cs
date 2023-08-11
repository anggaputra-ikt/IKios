using Application.Penyewa.Dtos;

namespace Application.Penyewa
{
    public interface IPenyewaService
    {
        Task<long> CreateAsync(PenyewaDto penyewaDto);
    }
}
