using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario
{
    public class PerfilDeUsuarioDomain : IPerfilDeUsuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public PerfilDeUsuarioDomain(Guid Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }
    }
}
