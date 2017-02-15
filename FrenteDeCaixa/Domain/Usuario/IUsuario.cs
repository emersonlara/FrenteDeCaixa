using FrenteDeCaixa.Domain.PerfilDeUsuario;
using System;

namespace FrenteDeCaixa.Domain.Usuario
{
    public interface IUsuario
    {
        Guid Id { get; set; }
        string Login { get; set; }
        string Senha { get; set; }
        string Nome { get; set; }
        Guid? PerfilId { get; set; }
        PerfilDeUsuarioDomain Perfil { get; set; }
    }
}
