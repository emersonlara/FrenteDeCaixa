using FrenteDeCaixa.Domain.PerfilDeUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.Usuario.Builder
{
    interface IUsuarioBuilder
    {
        UsuarioBuilder WithId(Guid Id);
        UsuarioBuilder WithLogin(string Login);
        UsuarioBuilder WithSenha(string Senha);
        UsuarioBuilder WithNome(string Nome);
        UsuarioBuilder WithPerfilId(Guid? PerfilId);
        UsuarioBuilder WithPerfil(PerfilDeUsuarioDomain Perfil);
        UsuarioDomain Build();
    }
}
