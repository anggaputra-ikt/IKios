using Application.Penyewa;
using Application.Penyewa.Dtos;
using AutoMapper;
using Infrastructure.Contexts;

namespace Infrastructure.Penyewa
{
    public class PenyewaService : IPenyewaService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public PenyewaService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<long> CreateAsync(PenyewaDto penyewaDto)
        {
            var penyewa = mapper.Map<Domain.Entities.Penyewa>(penyewaDto);
            await context.SaveChangesAsync();
            return penyewaDto.Id;
        }
    }
}
