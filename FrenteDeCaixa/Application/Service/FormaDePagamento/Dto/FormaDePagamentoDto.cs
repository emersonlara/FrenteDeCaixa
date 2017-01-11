using System;

namespace FrenteDeCaixa.Application.Service.FormaDePagamento.Dto
{
    public class FormaDePagamentoDto : IFormaDePagamentoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
