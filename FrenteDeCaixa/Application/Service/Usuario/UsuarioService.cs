using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FrenteDeCaixa.Application.Service.Usuario.Dto;
using FrenteDeCaixa.Domain.Usuario;
using FrenteDeCaixa.Domain.Usuario.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service.Usuario
{
    public class UsuarioService : IUsuarioService
    {
        private EntidadesContext Context { get; }

        public UsuarioService()
        {
            Context = new EntidadesContext();
        }

        public IUsuarioDto Salvar(UsuarioDto usuarioDto)
        {
            if (usuarioDto == null)
            {
                return new UsuarioDto();
            }
            var usuario = CriarParaSalvar(usuarioDto);

            Context.Usuarios.Add(usuario);
            Context.SaveChanges();

            return usuarioDto;
        }

        public IUsuarioDto Alterar(UsuarioDto usuarioDto)
        {
            if (usuarioDto == null) return new UsuarioDto();

            var usuario = CriarParaAlterar(usuarioDto);

            Context.Entry(usuario).State = EntityState.Modified;
            Context.SaveChanges();

            return usuarioDto;
        }

        public IUsuarioDto Excluir(UsuarioDto usuarioDto)
        {
            if (usuarioDto == null) return new UsuarioDto();

            var usuario = CriarParaExcluir(usuarioDto);

            Context.Entry(usuario).State = EntityState.Modified;
            Context.SaveChanges();

            return usuarioDto;
        }

        public List<UsuarioDomain> Listar()
        {
            return (from usuario in Context.Usuarios select usuario).ToList();
        }

        public UsuarioDomain CriarParaSalvar(UsuarioDto usuarioDto)
        {
            var usuario = new UsuarioBuilder()
                .WithId(Guid.NewGuid())
                .WithLogin(usuarioDto.Login)
                .WithNome(usuarioDto.Nome)
                .WithPerfil(usuarioDto.Perfil)
                .WithPerfilId(usuarioDto.PerfilId)
                .WithSenha(usuarioDto.Senha)
                .WithExcluido(false)
                .Build();

            return usuario;
        }

        public UsuarioDomain CriarParaAlterar(UsuarioDto usuarioDto)
        {
            var _usuario = Context.Usuarios.FirstOrDefault(x => x.Id == usuarioDto.Id);

            if (_usuario == null) throw new ArgumentNullException(nameof(_usuario));

            var usuario = new UsuarioBuilder()
                .WithId(_usuario.Id)
                .WithLogin(_usuario.Login)
                .WithNome(_usuario.Nome)
                .WithPerfil(_usuario.Perfil)
                .WithPerfilId(_usuario.PerfilId)
                .WithSenha(_usuario.Senha)
                .WithExcluido(_usuario.Excluido)
                .Build();

            return usuario;
        }

        public UsuarioDomain CriarParaExcluir(UsuarioDto usuarioDto)
        {
            var _usuario = Context.Usuarios.FirstOrDefault(x => x.Id == usuarioDto.Id);

            if (_usuario == null) throw new ArgumentNullException(nameof(_usuario));

            var usuario = new UsuarioBuilder()
                .WithId(_usuario.Id)
                .WithLogin(_usuario.Login)
                .WithNome(_usuario.Nome)
                .WithPerfil(_usuario.Perfil)
                .WithPerfilId(_usuario.PerfilId)
                .WithSenha(_usuario.Senha)
                .WithExcluido(true)
                .Build();

            return usuario;
        }
    }
}
