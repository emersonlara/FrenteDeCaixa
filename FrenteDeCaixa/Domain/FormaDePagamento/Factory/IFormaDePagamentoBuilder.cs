using System;

namespace FrenteDeCaixa.Domain.FormaDePagamento.Factory
{
    public interface IFormaDePagamentoBuilder
    {
        FormaDePagamentoBuilder WithId(Guid id);
        FormaDePagamentoBuilder WithNome(string nome);
        FormaDePagamentoDomain Build();
    }
}
