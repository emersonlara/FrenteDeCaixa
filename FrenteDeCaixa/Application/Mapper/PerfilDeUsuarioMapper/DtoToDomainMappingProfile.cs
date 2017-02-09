using AutoMapper;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Application.Mapper.PerfilDeUsuarioMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<PerfilDeUsuarioDto, PerfilDeUsuarioDomain>();
            });

            AutoMapper.Mapper.Initialize(x =>
            {
                x.CreateMap<PerfilDeUsuarioDto, PerfilDeUsuarioDomain>();
            });
        }
    }
}
