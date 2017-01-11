using System;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using FrenteDeCaixa.Domain.PerfilDeUsuario.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service.PerfilDeUsuario
{
    class PerfilDeUsuarioService : IPerfilDeUsuarioService
    {
        private EntidadesContext Banco { get; }

        public PerfilDeUsuarioService()
        {
            Banco = new EntidadesContext();
        }

        public IPerfilDeUsuarioDto Salvar(PerfilDeUsuarioDto perfilDeUsuarioDto)
        {
            if (perfilDeUsuarioDto == null)
            {
                return new PerfilDeUsuarioDto();
            }

            var perfilDeUsuario = CriarParaSalvar(perfilDeUsuarioDto);

            Banco.PerfisDeUsuarios.Add(perfilDeUsuario);
            Banco.SaveChanges();

            return perfilDeUsuarioDto;
        }

        public void Alterar(PerfilDeUsuarioDomain perfil)
        {
            var perfilAux = Banco.PerfisDeUsuarios.First(x => x.Id == perfil.Id);
            perfilAux.Nome = perfil.Nome;
            Banco.SaveChanges();
        }

        public void Excluir(PerfilDeUsuarioDomain perfil)
        {
            Banco.Set<PerfilDeUsuarioDomain>().Remove(perfil);
            Banco.SaveChanges();
        }

        public List<PerfilDeUsuarioDomain> Listar()
        {
            return (from c in Banco.PerfisDeUsuarios select c).ToList();
        }

        public PerfilDeUsuarioDomain CriarParaSalvar(PerfilDeUsuarioDto perfilDeUsuarioDto)
        {
            var perfilDeUsuario = new PerfilDeUsuarioBuilder()
                .WithId(Guid.NewGuid())
                .WithNome(perfilDeUsuarioDto.Nome)
                .Build();

            return perfilDeUsuario;
        }
    }
}
