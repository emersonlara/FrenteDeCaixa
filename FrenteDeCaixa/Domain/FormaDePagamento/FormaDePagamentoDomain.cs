using System;

namespace FrenteDeCaixa.Domain.FormaDePagamento
{
    public class FormaDePagamentoDomain : IFormaDePagamento
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public FormaDePagamentoDomain(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
