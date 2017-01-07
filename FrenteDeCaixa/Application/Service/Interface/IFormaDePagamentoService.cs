using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.FormaDePagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
