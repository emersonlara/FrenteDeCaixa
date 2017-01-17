using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.FormaDePagamento.Dto;
using FrenteDeCaixa.Domain.FormaDePagamento;

namespace FrenteDeCaixa.Application.Service.FormaDePagamento
{
    public interface IFormaDePagamentoService
    {
        IFormaDePagamentoDto Salvar(FormaDePagamentoDto formaDePagamentoDto);
        IFormaDePagamentoDto Alterar(FormaDePagamentoDto formaDePagamento);
        IFormaDePagamentoDto Excluir(FormaDePagamentoDto formaDePagamento);
        List<FormaDePagamentoDomain> Listar();
        FormaDePagamentoDomain CriarParaSalvar(FormaDePagamentoDto formaDePagamentoDto);
        FormaDePagamentoDomain CriarParaAlterar(FormaDePagamentoDto formaDePagamentoDto);
        FormaDePagamentoDomain CriarParaExcluir(FormaDePagamentoDto formaDePagamentoDto);
    }
}
