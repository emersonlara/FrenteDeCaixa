using System;
using System.Collections.Generic;
using System.Data.Entity;
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

            var perfilDeUsuario = CriarParaAlterar(perfilDeUsuarioDto);

            Context.Entry(perfilDeUsuario).State = EntityState.Modified;
            Context.SaveChanges();

            return perfilDeUsuarioDto;
        }

        public IPerfilDeUsuarioDto Excluir(PerfilDeUsuarioDto perfilDeUsuarioDto)
        {
            if (perfilDeUsuarioDto == null) return new PerfilDeUsuarioDto();

            var perfilDeUsuario = CriarParaExcluir(perfilDeUsuarioDto);

            Context.Entry(perfilDeUsuario).State = EntityState.Modified;
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
                .WithExcluido(false)
                .Build();

            return perfilDeUsuario;
        }

        public PerfilDeUsuarioDomain CriarParaAlterar(PerfilDeUsuarioDto perfilDeUsuarioDto)
        {
            var _perfilDeUsuario = Context.PerfisDeUsuarios.FirstOrDefault(x => x.Id == perfilDeUsuarioDto.Id);

            if (_perfilDeUsuario == null) throw new ArgumentNullException(nameof(_perfilDeUsuario));

            var perfilDeUsuario = new PerfilDeUsuarioBuilder()
                .WithId(_perfilDeUsuario.Id)
                .WithNome(_perfilDeUsuario.Nome)
                .WithExcluido(_perfilDeUsuario.Excluido)
                .Build();

            return perfilDeUsuario;
        }

        public PerfilDeUsuarioDomain CriarParaExcluir(PerfilDeUsuarioDto perfilDeUsuarioDto)
        {
            var _perfilDeUsuario = Context.PerfisDeUsuarios.FirstOrDefault(x => x.Id == perfilDeUsuarioDto.Id);

            if (_perfilDeUsuario == null) throw new ArgumentNullException(nameof(_perfilDeUsuario));

            var perfilDeUsuario = new PerfilDeUsuarioBuilder()
                .WithId(_perfilDeUsuario.Id)
                .WithNome(_perfilDeUsuario.Nome)
                .WithExcluido(true)
                .Build();

            return perfilDeUsuario;
        }
    }
}
