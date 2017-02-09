using System;
using AutoMapper;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Application.Mapper.PerfilDeUsuarioMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        protected override void Configure()
        {
            AutoMapper.Mapper.Initialize(x =>
            {
                x.CreateMap<PerfilDeUsuarioDomain, PerfilDeUsuarioDto>();
                Console.WriteLine("DOMAINTODTO------------------------------------------------------------------------");
            });
        }
    }
}
