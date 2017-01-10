using System;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Domain.Usuario.Factory
{
    class UsuarioBuilder : IUsuarioBuilder
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public Guid? PerfilId { get; set; }
        public PerfilDeUsuarioDomain Perfil { get; set; }

        public UsuarioBuilder WithId(Guid id)
        {
            Id = id;
            return this;
        }

        public UsuarioBuilder WithLogin(string login)
        {
            Login = login;
            return this;
        }

        public UsuarioBuilder WithSenha(string senha)
        {
            Senha = senha;
            return this;
        }

        public UsuarioBuilder WithNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public UsuarioBuilder WithPerfilId(Guid? perfilId)
        {
            PerfilId = perfilId;
            return this;
        }

        public UsuarioBuilder WithPerfil(PerfilDeUsuarioDomain perfil)
        {
            Perfil = perfil;
            return this;
        }

        public UsuarioDomain Build()
        {
            return new UsuarioDomain(Id, Login, Senha, Nome, PerfilId, Perfil);
        }
    }
}
