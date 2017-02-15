using System;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario
{
    public interface IPerfilDeUsuario
    {
        Guid Id { get; set; }
        string Nome { get; set; }
    }
}
