using System;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario
{
    interface IPerfilDeUsuario
    {
        Guid Id { get; set; }
        string Nome { get; set; }
    }
}
