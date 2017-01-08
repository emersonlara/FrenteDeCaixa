using FrenteDeCaixa.Domain.FormaDePagamento;
using System.Collections.Generic;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IFormaDePagamentoService
    {
        void Salvar(FormaDePagamentoDomain formaDePagamento);
        void Alterar(FormaDePagamentoDomain formaDePagamento);
        void Excluir(FormaDePagamentoDomain formaDePagamento);
        List<FormaDePagamentoDomain> Listar();
    }
}
