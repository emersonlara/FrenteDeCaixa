using System;

namespace FrenteDeCaixa.Domain.FormaDePagamento
{
    public interface IFormaDePagamento
    {
        Guid Id { get; set; }
        string Nome { get; set; }
        bool Excluido { get; set; }
    }
}
