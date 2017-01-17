using System;

namespace FrenteDeCaixa.Domain.FormaDePagamento.Factory
{
    public class FormaDePagamentoBuilder : IFormaDePagamentoBuilder
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Excluido { get; set; }

        public FormaDePagamentoBuilder WithId(Guid id)
        {
            Id = id;
            return this;
        }

        public FormaDePagamentoBuilder WithNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public FormaDePagamentoBuilder WithExcluido(bool excluido)
        {
            Excluido = excluido;
            return this;
        }

        public FormaDePagamentoDomain Build()
        {
            return new FormaDePagamentoDomain(Id, Nome, Excluido);
        }
    }
}
