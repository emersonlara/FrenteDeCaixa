using System;

namespace FrenteDeCaixa.Domain.FormaDePagamento.Builder
{
    interface IFormaDePagamentoBuilder
    {
        FormaDePagamentoBuilder WithId(Guid id);
        FormaDePagamentoBuilder WithNome(string nome);
        FormaDePagamentoDomain Build();
    }
}
