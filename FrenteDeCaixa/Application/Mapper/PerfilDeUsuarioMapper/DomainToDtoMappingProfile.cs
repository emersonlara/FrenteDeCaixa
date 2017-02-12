using AutoMapper;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Application.Mapper.PerfilDeUsuarioMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<PerfilDeUsuarioDomain, PerfilDeUsuarioDto>();
        }
    }
}
