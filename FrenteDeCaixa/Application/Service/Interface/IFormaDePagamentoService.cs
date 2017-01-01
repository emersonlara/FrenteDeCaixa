using FrenteDeCaixa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IFormaDePagamentoService
    {
        void Salvar(FormaDePagamento formaDePagamento);
        void Alterar(FormaDePagamento formaDePagamento);
        void Excluir(FormaDePagamento formaDePagamento);
        List<FormaDePagamento> Listar();
    }
}
