using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using FrenteDeCaixa.Domain.PerfilDeUsuario.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service.PerfilDeUsuario
{
    public class PerfilDeUsuarioService : IPerfilDeUsuarioService
    {
        private EntidadesContext Context { get; }

        public PerfilDeUsuarioService()
        {
            Context = new EntidadesContext();
        }

        public IPerfilDeUsuarioDto Salvar(PerfilDeUsuarioDto perfilDeUsuarioDto)
        {
            if (perfilDeUsuarioDto == null) return new PerfilDeUsuarioDto();

            var perfilDeUsuario = CriarParaSalvar(perfilDeUsuarioDto);

            Context.PerfisDeUsuarios.Add(perfilDeUsuario);
            Context.SaveChanges();

            return perfilDeUsuarioDto;
        }

        public IPerfilDeUsuarioDto Alterar(PerfilDeUsuarioDto perfilDeUsuarioDto)
        {
            if (perfilDeUsuarioDto == null) return new PerfilDeUsuarioDto();

            var perfilDeUsuario = ProcurarParaCriar(perfilDeUsuarioDto);

            Context.PerfisDeUsuarios.AddOrUpdate(perfilDeUsuario);
            Context.SaveChanges();

            return perfilDeUsuarioDto;
        }

        public IPerfilDeUsuarioDto Excluir(PerfilDeUsuarioDto perfilDeUsuarioDto)
        {
            if (perfilDeUsuarioDto == null) return new PerfilDeUsuarioDto();

            var perfilDeUsuario = Context.PerfisDeUsuarios.FirstOrDefault(x => x.Id == perfilDeUsuarioDto.Id);

            if (perfilDeUsuario != null) Context.PerfisDeUsuarios.Remove(perfilDeUsuario);
            Context.SaveChanges();

            return perfilDeUsuarioDto;
        }

        public List<PerfilDeUsuarioDomain> Listar()
        {
            return (from c in Context.PerfisDeUsuarios select c).ToList();
        }

        public PerfilDeUsuarioDomain CriarParaSalvar(PerfilDeUsuarioDto perfilDeUsuarioDto)
        {
            var perfilDeUsuario = new PerfilDeUsuarioBuilder()
                .WithId(Guid.NewGuid())
                .WithNome(perfilDeUsuarioDto.Nome)
                .Build();

            return perfilDeUsuario;
        }

        public PerfilDeUsuarioDomain ProcurarParaCriar(PerfilDeUsuarioDto perfilDeUsuarioDto)
        {
            var perfil = Context.PerfisDeUsuarios.FirstOrDefault(x => x.Id == perfilDeUsuarioDto.Id);

            if (perfil == null) throw new ArgumentNullException(nameof(perfil));

            var perfilDeUsuario = new PerfilDeUsuarioBuilder()
                .WithId(perfil.Id)
                .WithNome(perfilDeUsuarioDto.Nome)
                .Build();
                
            return perfilDeUsuario;
        }
    }
}
