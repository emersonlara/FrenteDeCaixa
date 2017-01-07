using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.FormaDePagamento.Builder
{
    interface IFormaDePagamentoBuilder
    {
        FormaDePagamentoBuilder WithId(Guid Id);
        FormaDePagamentoBuilder WithNome(string Nome);
        FormaDePagamentoDomain Build();
    }
}
