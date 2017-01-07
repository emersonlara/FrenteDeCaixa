using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Context;
using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.FormaDePagamento;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service
{
    class FormaDePagamentoService : IFormaDePagamentoService
    {
        private EntidadesContext Banco { get; set; }

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
            FormaDePagamentoDomain pagamentoAux = Banco.FormasDePagamentos
                .Where(x => x.Id == formaDePagamento.Id).First();
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
