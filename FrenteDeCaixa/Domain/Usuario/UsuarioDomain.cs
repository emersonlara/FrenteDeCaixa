using FrenteDeCaixa.Domain.PerfilDeUsuario;
using System;

namespace FrenteDeCaixa.Domain.Usuario
{
    public class UsuarioDomain : IUsuario
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public Guid? PerfilId { get; set; }
        public PerfilDeUsuarioDomain Perfil { get; set; }

        public UsuarioDomain(Guid id, string login, string senha, string nome, Guid? perfilId, PerfilDeUsuarioDomain perfil)
        {
            Id = id;
            Login = login;
            Senha = senha;
            Nome = nome;
            PerfilId = perfilId;
            Perfil = perfil;
        }
    }
}
