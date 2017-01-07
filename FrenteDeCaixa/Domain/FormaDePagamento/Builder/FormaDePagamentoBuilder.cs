using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.FormaDePagamento.Builder
{
    class FormaDePagamentoBuilder : IFormaDePagamentoBuilder
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public FormaDePagamentoBuilder WithId(Guid Id)
        {
            this.Id = Id;
            return this;
        }

        public FormaDePagamentoBuilder WithNome(string Nome)
        {
            this.Nome = Nome;
            return this;
        }

        public FormaDePagamentoDomain Build()
        {
            return new FormaDePagamentoDomain(Id, Nome);
        }
    }
}
