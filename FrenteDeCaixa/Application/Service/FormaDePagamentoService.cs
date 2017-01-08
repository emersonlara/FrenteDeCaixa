using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Domain.FormaDePagamento;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service
{
    class FormaDePagamentoService : IFormaDePagamentoService
    {
        private EntidadesContext Banco { get; }

        public FormaDePagamentoService()
        {
            Banco = new EntidadesContext();
        }

        public void Salvar(FormaDePagamentoDomain formaDePagamento)
        {
            Banco.FormasDePagamentos.Add(formaDePagamento);
            Banco.SaveChanges();
        }

        public void Alterar(FormaDePagamentoDomain formaDePagamento)
        {
            FormaDePagamentoDomain pagamentoAux = Banco.FormasDePagamentos.First(x => x.Id == formaDePagamento.Id);
            pagamentoAux.Nome = formaDePagamento.Nome;
            Banco.SaveChanges();
        }

        public void Excluir(FormaDePagamentoDomain formaDePagamento)
        {
            Banco.Set<FormaDePagamentoDomain>().Remove(formaDePagamento);
            Banco.SaveChanges();
        }

        public List<FormaDePagamentoDomain> Listar()
        {
            return (from c in Banco.FormasDePagamentos select c).ToList();
        }
    }
}
