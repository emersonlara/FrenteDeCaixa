using System;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario
{
    public class PerfilDeUsuarioDomain : IPerfilDeUsuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public PerfilDeUsuarioDomain() { }

        public PerfilDeUsuarioDomain(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
