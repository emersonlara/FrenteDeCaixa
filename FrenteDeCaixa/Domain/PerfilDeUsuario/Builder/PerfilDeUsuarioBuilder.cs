using System;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario.Builder
{
    class PerfilDeUsuarioBuilder : IPerfilDeUsuarioBuilder
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public PerfilDeUsuarioBuilder WithId(Guid id)
        {
            Id = id;
            return this;
        }

        public PerfilDeUsuarioBuilder WithNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public PerfilDeUsuarioDomain Build()
        {
            return new PerfilDeUsuarioDomain(Id, Nome);
        }
    }
}
