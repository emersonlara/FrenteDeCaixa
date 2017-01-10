using System;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario.Factory
{
    interface IPerfilDeUsuarioBuilder
    {
        PerfilDeUsuarioBuilder WithId(Guid id);
        PerfilDeUsuarioBuilder WithNome(string nome);
        PerfilDeUsuarioDomain Build();
    }
}
