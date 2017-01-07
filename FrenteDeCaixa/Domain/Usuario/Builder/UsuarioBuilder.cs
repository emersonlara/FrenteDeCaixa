using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Domain.Usuario.Builder
{
    class UsuarioBuilder : IUsuarioBuilder
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public Guid? PerfilId { get; set; }
        public PerfilDeUsuarioDomain Perfil { get; set; }

        public UsuarioBuilder WithId(Guid Id)
        {
            this.Id = Id;
            return this;
        }

        public UsuarioBuilder WithLogin(string Login)
        {
            this.Login = Login;
            return this;
        }

        public UsuarioBuilder WithSenha(string Senha)
        {
            this.Senha = Senha;
            return this;
        }

        public UsuarioBuilder WithNome(string Nome)
        {
            this.Nome = Nome;
            return this;
        }

        public UsuarioBuilder WithPerfilId(Guid? PerfilId)
        {
            this.PerfilId = PerfilId;
            return this;
        }

        public UsuarioBuilder WithPerfil(PerfilDeUsuarioDomain Perfil)
        {
            this.Perfil = Perfil;
            return this;
        }

        public UsuarioDomain Build()
        {
            return new UsuarioDomain(Id, Login, Senha, Nome, PerfilId, Perfil);
        }
    }
}
