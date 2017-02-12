using AutoMapper;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Application.Mapper.PerfilDeUsuarioMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<PerfilDeUsuarioDto, PerfilDeUsuarioDomain>();
        }
    }
}
