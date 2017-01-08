using System;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario.Builder
{
    interface IPerfilDeUsuarioBuilder
    {
        PerfilDeUsuarioBuilder WithId(Guid id);
        PerfilDeUsuarioBuilder WithNome(string nome);
        PerfilDeUsuarioDomain Build();
    }
}
