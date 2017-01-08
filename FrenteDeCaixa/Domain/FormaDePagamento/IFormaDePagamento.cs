using System;

namespace FrenteDeCaixa.Domain.FormaDePagamento
{
    interface IFormaDePagamento
    {
        Guid Id { get; set; }
        string Nome { get; set; }
    }
}
