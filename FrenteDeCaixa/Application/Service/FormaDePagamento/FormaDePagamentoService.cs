using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FrenteDeCaixa.Application.Service.FormaDePagamento.Dto;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.FormaDePagamento.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service.FormaDePagamento
{
    public class FormaDePagamentoService : IFormaDePagamentoService
    {
        private EntidadesContext Context { get; }

        public FormaDePagamentoService()
        {
            Context = new EntidadesContext();
        }

        public IFormaDePagamentoDto Salvar(FormaDePagamentoDto formaDePagamentoDto)
        {
            if (formaDePagamentoDto == null) return new FormaDePagamentoDto();
            
            // TODO aqui chamar o validator do Dto

            var formaDePagamento = CriarParaSalvar(formaDePagamentoDto);

            Context.FormasDePagamentos.Add(formaDePagamento);
            Context.SaveChanges();

            return formaDePagamentoDto;
        }

        public IFormaDePagamentoDto Alterar(FormaDePagamentoDto formaDePagamentoDto)
        {
            if (formaDePagamentoDto == null) return new FormaDePagamentoDto();

            var formaDePagamento = CriarParaAlterar(formaDePagamentoDto);

            Context.Entry(formaDePagamento).State = EntityState.Modified;
            Context.SaveChanges();

            return formaDePagamentoDto;
        }

        public IFormaDePagamentoDto Excluir(FormaDePagamentoDto formaDePagamentoDto)
        {
            if (formaDePagamentoDto == null) return new FormaDePagamentoDto();

            var formaDePagamento = CriarParaExcluir(formaDePagamentoDto);

            Context.Entry(formaDePagamento).State = EntityState.Modified;
            Context.SaveChanges();

            return formaDePagamentoDto;
        }

        public List<FormaDePagamentoDomain> Listar()
        {
            return (from c in Context.FormasDePagamentos select c).ToList();
        }

        public FormaDePagamentoDomain CriarParaSalvar(FormaDePagamentoDto formaDePagamentoDto)
        {
            var formaDePagamento = new FormaDePagamentoBuilder()
                .WithId(Guid.NewGuid())
                .WithNome(formaDePagamentoDto.Nome)
                .WithExcluido(false)
                .Build();

            return formaDePagamento;
        }

        public FormaDePagamentoDomain CriarParaAlterar(FormaDePagamentoDto formaDePagamentoDto)
        {
            var _formaDePagamento = Context.FormasDePagamentos.FirstOrDefault(x => x.Id == formaDePagamentoDto.Id);

            if (_formaDePagamento == null) throw new ArgumentNullException(nameof(_formaDePagamento));

            var formaDePagamento = new FormaDePagamentoBuilder()
                .WithId(_formaDePagamento.Id)
                .WithNome(_formaDePagamento.Nome)
                .WithExcluido(_formaDePagamento.Excluido)
                .Build();

            return formaDePagamento;
        }

        public FormaDePagamentoDomain CriarParaExcluir(FormaDePagamentoDto formaDePagamentoDto)
        {
            var _formaDePagamento = Context.FormasDePagamentos.FirstOrDefault(x => x.Id == formaDePagamentoDto.Id);

            if (_formaDePagamento == null) throw new ArgumentNullException(nameof(_formaDePagamento));

            var formaDePagamento = new FormaDePagamentoBuilder()
                .WithId(_formaDePagamento.Id)
                .WithNome(_formaDePagamento.Nome)
                .WithExcluido(true)
                .Build();

            return formaDePagamento;
        }
    }
}
