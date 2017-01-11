using System;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Application.Service.Usuario.Dto;
using FrenteDeCaixa.Domain.Usuario;
using FrenteDeCaixa.Domain.Usuario.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service.Usuario
{
    class UsuarioService : IUsuarioService
    {
        private EntidadesContext Banco { get; }

        public UsuarioService()
        {
            Banco = new EntidadesContext();
        }

        public IUsuarioDto Salvar(UsuarioDto usuarioDto)
        {
            if (usuarioDto == null)
            {
                return new UsuarioDto();
            }
            var usuario = CriarParaSalvar(usuarioDto);

            Banco.Usuarios.Add(usuario);
            Banco.SaveChanges();

            return usuarioDto;
        }

        public void Alterar(UsuarioDomain usuario)
        {
            var usuarioAux = Banco.Usuarios.First(x => x.Id == usuario.Id);
            usuarioAux.Login = usuario.Login;
            usuarioAux.Senha = usuario.Senha;
            usuarioAux.Nome  = usuario.Nome;
            usuarioAux.PerfilId = usuario.PerfilId;
            usuarioAux.Perfil   = usuario.Perfil;
            Banco.SaveChanges();
        }

        public void Excluir(UsuarioDomain usuario)
        {
            Banco.Set<UsuarioDomain>().Remove(usuario);
            Banco.SaveChanges();
        }

        public List<UsuarioDomain> Listar()
        {
            return (from c in Banco.Usuarios select c).ToList();
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
                .Build();

            return usuario;
        }
    }
}
