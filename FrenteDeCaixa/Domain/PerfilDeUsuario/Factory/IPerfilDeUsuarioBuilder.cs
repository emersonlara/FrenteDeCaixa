using System;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario.Factory
{
    public interface IPerfilDeUsuarioBuilder
    {
        PerfilDeUsuarioBuilder WithId(Guid id);
        PerfilDeUsuarioBuilder WithNome(string nome);
        PerfilDeUsuarioDomain Build();
    }
}
