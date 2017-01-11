using System;

namespace FrenteDeCaixa.Application.Service.FormaDePagamento.Dto
{
    public interface IFormaDePagamentoDto
    {
        Guid Id { get; }
        string Nome { get; }
    }
}
