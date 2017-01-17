using System;

namespace FrenteDeCaixa.Domain.FormaDePagamento.Factory
{
    public interface IFormaDePagamentoBuilder
    {
        FormaDePagamentoBuilder WithId(Guid id);
        FormaDePagamentoBuilder WithNome(string nome);
        FormaDePagamentoBuilder WithExcluido(bool excluido);
        FormaDePagamentoDomain Build();
    }
}
