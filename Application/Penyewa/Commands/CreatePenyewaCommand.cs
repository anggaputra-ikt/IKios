using Application.Penyewa.Dtos;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Penyewa.Commands
{
    public class CreatePenyewaCommand : IRequest<long>
    {
        public CreatePenyewaCommand(PenyewaDto penyewaDto)
        {
            PenyewaDto = penyewaDto;
        }

        public PenyewaDto? PenyewaDto { get; set; }
    }

    public class CreatePenyewaCommandHandler : IRequestHandler<CreatePenyewaCommand, long>
    {
        private readonly IPenyewaService penyewaService;
        private readonly IMapper mapper;

        public CreatePenyewaCommandHandler(IPenyewaService penyewaService, IMapper mapper)
        {
            this.penyewaService = penyewaService;
            this.mapper = mapper;
        }

        public async Task<long> Handle(CreatePenyewaCommand request, CancellationToken cancellationToken)
        {
            var requestDto = mapper.Map<PenyewaDto>(request.PenyewaDto);
            var createPenyewa = await penyewaService.CreateAsync(requestDto);
            return createPenyewa;
        }
    }
}
