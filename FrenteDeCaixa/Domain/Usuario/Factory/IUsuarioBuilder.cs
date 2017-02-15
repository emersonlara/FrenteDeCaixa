using System;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Domain.Usuario.Factory
{
    public interface IUsuarioBuilder
    {
        UsuarioBuilder WithId(Guid id);
        UsuarioBuilder WithLogin(string login);
        UsuarioBuilder WithSenha(string senha);
        UsuarioBuilder WithNome(string nome);
        UsuarioBuilder WithPerfilId(Guid? perfilId);
        UsuarioBuilder WithPerfil(PerfilDeUsuarioDomain perfil);
        UsuarioDomain Build();
    }
}
