using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.FormaDePagamento
{
    public class FormaDePagamentoDomain : IFormaDePagamento
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public FormaDePagamentoDomain(Guid Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }
    }
}
