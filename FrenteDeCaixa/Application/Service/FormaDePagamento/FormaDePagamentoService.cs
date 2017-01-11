using System;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Application.Service.Cliente.Dto;
using FrenteDeCaixa.Application.Service.FormaDePagamento.Dto;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.FormaDePagamento.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service.FormaDePagamento
{
    class FormaDePagamentoService : IFormaDePagamentoService
    {
        private EntidadesContext Banco { get; }

        public FormaDePagamentoService()
        {
            Banco = new EntidadesContext();
        }

        public IFormaDePagamentoDto Salvar(FormaDePagamentoDto formaDePagamentoDto)
        {
            if (formaDePagamentoDto == null)
            {
                return new FormaDePagamentoDto();
            }

            // TODO aqui chamar o validator do Dto

            var formaDePagamento = CriarParaSalvar(formaDePagamentoDto);

            Banco.FormasDePagamentos.Add(formaDePagamento);
            Banco.SaveChanges();

            return formaDePagamentoDto;
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

        public FormaDePagamentoDomain CriarParaSalvar(FormaDePagamentoDto formaDePagamentoDto)
        {
            var formaDePagamento = new FormaDePagamentoBuilder()
                .WithId(Guid.NewGuid())
                .WithNome(formaDePagamentoDto.Nome)
                .Build();

            return formaDePagamento;
        }
    }
}
