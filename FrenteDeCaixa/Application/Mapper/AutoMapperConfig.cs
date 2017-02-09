using System;
using FrenteDeCaixa.Application.Mapper.PerfilDeUsuarioMapper;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Application.Mapper
{
    public class AutoMapperConfig
    {
        public void RegisterMappings()
        {
            AutoMapper.Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToDtoMappingProfile>();
                x.AddProfile<DtoToDomainMappingProfile>();

                //x.CreateMap<PerfilDeUsuarioDto, PerfilDeUsuarioDomain>();
            });
            Console.WriteLine("AUTOMAPPER------------------------------------------------------------------------");


        }
    }
}
