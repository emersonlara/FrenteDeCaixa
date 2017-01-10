using System;

namespace FrenteDeCaixa.Domain.FormaDePagamento.Factory
{
    interface IFormaDePagamentoBuilder
    {
        FormaDePagamentoBuilder WithId(Guid id);
        FormaDePagamentoBuilder WithNome(string nome);
        FormaDePagamentoDomain Build();
    }
}
