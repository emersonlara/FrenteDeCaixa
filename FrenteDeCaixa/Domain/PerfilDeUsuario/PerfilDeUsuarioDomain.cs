using System;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario
{
    public class PerfilDeUsuarioDomain : IPerfilDeUsuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Excluido { get; set; }

        public PerfilDeUsuarioDomain(Guid id, string nome, bool excluido)
        {
            Id = id;
            Nome = nome;
            Excluido = excluido;
        }
    }
}
