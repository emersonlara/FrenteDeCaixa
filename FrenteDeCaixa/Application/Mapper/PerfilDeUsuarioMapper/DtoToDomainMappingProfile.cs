using AutoMapper;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Application.Mapper.PerfilDeUsuarioMapper
{
    public class DtoToDomainMappingProfile : Profile
    {

    protected override void Configure()
        {
            CreateMap<PerfilDeUsuarioDto, PerfilDeUsuarioDomain>()
                .ForMember(
                dest => dest.Id,
                ori => ori.MapFrom(x => x.Id))
            .ForMember(
                dest => dest.Nome,
                ori => ori.MapFrom(x => x.Nome));
        }
    }
}
