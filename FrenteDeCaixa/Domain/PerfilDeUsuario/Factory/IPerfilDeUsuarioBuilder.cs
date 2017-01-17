using System;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario.Factory
{
    public interface IPerfilDeUsuarioBuilder
    {
        PerfilDeUsuarioBuilder WithId(Guid id);
        PerfilDeUsuarioBuilder WithNome(string nome);
        PerfilDeUsuarioBuilder WithExcluido(bool excluido);
        PerfilDeUsuarioDomain Build();
    }
}
