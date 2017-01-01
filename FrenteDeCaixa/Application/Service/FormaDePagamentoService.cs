using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Context;
using FrenteDeCaixa.Domain;
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

        public void Salvar(FormaDePagamento formaDePagamento)
        {
            Banco.FormasDePagamentos.Add(formaDePagamento);
            Banco.SaveChanges();
        }

        public void Alterar(FormaDePagamento formaDePagamento)
        {
            FormaDePagamento pagamentoAux = Banco.FormasDePagamentos
                .Where(x => x.Id == formaDePagamento.Id).First();
            pagamentoAux.Nome = formaDePagamento.Nome;
            Banco.SaveChanges();
        }

        public void Excluir(FormaDePagamento formaDePagamento)
        {
            Banco.Set<FormaDePagamento>().Remove(formaDePagamento);
            Banco.SaveChanges();
        }

        public List<FormaDePagamento> Listar()
        {
            return (from c in Banco.FormasDePagamentos select c).ToList();
        }
    }
}
