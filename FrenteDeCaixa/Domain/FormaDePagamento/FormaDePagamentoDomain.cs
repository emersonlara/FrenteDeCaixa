using System;

namespace FrenteDeCaixa.Domain.FormaDePagamento
{
    public class FormaDePagamentoDomain : IFormaDePagamento
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Excluido { get; set; }

        public FormaDePagamentoDomain(Guid id, string nome, bool excluido)
        {
            Id = id;
            Nome = nome;
            Excluido = excluido;
        }
    }
}
