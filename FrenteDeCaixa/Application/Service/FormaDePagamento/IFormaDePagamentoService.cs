using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.FormaDePagamento.Dto;
using FrenteDeCaixa.Domain.FormaDePagamento;

namespace FrenteDeCaixa.Application.Service.FormaDePagamento
{
    interface IFormaDePagamentoService
    {
        IFormaDePagamentoDto Salvar(FormaDePagamentoDto formaDePagamentoDto);
        void Alterar(FormaDePagamentoDomain formaDePagamento);
        void Excluir(FormaDePagamentoDomain formaDePagamento);
        List<FormaDePagamentoDomain> Listar();
        FormaDePagamentoDomain CriarParaSalvar(FormaDePagamentoDto formaDePagamentoDto);
    }
}
