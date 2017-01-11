using System;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Application.Service.Usuario.Dto
{
    public interface IUsuarioDto
    {
        Guid Id { get; }
        string Login { get; }
        string Senha { get; }
        string Nome { get; }
        Guid? PerfilId { get; }
        PerfilDeUsuarioDomain Perfil { get; }
    }
}
