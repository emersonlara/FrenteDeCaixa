using System;
using AutoMapper;
using FrenteDeCaixa.Application.Mapper.PerfilDeUsuarioMapper;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Application.Mapper
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper;

        public void RegisterMappings()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToDtoMappingProfile());
                cfg.AddProfile(new DtoToDomainMappingProfile());
            });
            Mapper = config.CreateMapper();
        }
    }
}
