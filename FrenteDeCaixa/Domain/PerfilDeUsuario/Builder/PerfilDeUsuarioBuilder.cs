using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario.Builder
{
    class PerfilDeUsuarioBuilder : IPerfilDeUsuarioBuilder
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public PerfilDeUsuarioBuilder WithId(Guid Id)
        {
            this.Id = Id;
            return this;
        }

        public PerfilDeUsuarioBuilder WithNome(string Nome)
        {
            this.Nome = Nome;
            return this;
        }

        public PerfilDeUsuarioDomain Build()
        {
            return new PerfilDeUsuarioDomain(Id, Nome);
        }
    }
}
