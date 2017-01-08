using FrenteDeCaixa.Domain.PerfilDeUsuario;
using System;

namespace FrenteDeCaixa.Domain.Usuario.Builder
{
    interface IUsuarioBuilder
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
