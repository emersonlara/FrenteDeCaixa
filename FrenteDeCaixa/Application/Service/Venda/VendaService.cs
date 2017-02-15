using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FrenteDeCaixa.Application.Service.Venda.Dto;
using FrenteDeCaixa.Domain.Venda;
using FrenteDeCaixa.Domain.Venda.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service.Venda
{
    public class VendaService : IVendaService
    {
        private EntidadesContext Context { get; }

        public VendaService()
        {
            Context = new EntidadesContext();
        }

        public IVendaDto Salvar(VendaDto vendaDto)
        {
            if (vendaDto == null)
            {
                return new VendaDto();
            }
            var venda = CriarParaSalvar(vendaDto);

            Context.Vendas.Add(venda);
            Context.SaveChanges();

            return vendaDto;
        }

        public IVendaDto Alterar(VendaDto vendaDto)
        {
            if (vendaDto == null) return new VendaDto();

            var venda = CriarParaAlterar(vendaDto);

            Context.Entry(venda).State = EntityState.Modified;
            Context.SaveChanges();

            return vendaDto;
        }

        public IVendaDto Excluir(VendaDto vendaDto)
        {
            if (vendaDto == null) return new VendaDto();

            var venda = CriarParaExcluir(vendaDto);

            Context.Entry(venda).State = EntityState.Modified;
            Context.SaveChanges();

            return vendaDto;
        }

        public List<VendaDomain> Listar()
        {
            return (from c in Context.Vendas select c).ToList();
        }

        public VendaDomain CriarParaSalvar(VendaDto vendaDto)
        {
            var venda = new VendaBuilder()
                .WithId(Guid.NewGuid())
                .WithCliente(vendaDto.Cliente)
                .WithClienteId(vendaDto.ClienteId)
                .WithFormaDePagamento(vendaDto.FormaDePagamento)
                .WithFormaDePagamentoId(vendaDto.FormaDePagamentoId)
                .WithUsuario(vendaDto.Usuario)
                .WithUsuarioId(vendaDto.UsuarioId)
                .WithValorTotal(vendaDto.ValorTotal)                
                .Build();

            return venda;
        }

        public VendaDomain CriarParaAlterar(VendaDto vendaDto)
        {
            var _venda = Context.Vendas.FirstOrDefault(x => x.Id == vendaDto.Id);

            if (_venda == null) throw new ArgumentNullException(nameof(_venda));

            var venda = new VendaBuilder()
                .WithId(_venda.Id)
                .WithCliente(_venda.Cliente)
                .WithClienteId(_venda.ClienteId)
                .WithFormaDePagamento(_venda.FormaDePagamento)
                .WithFormaDePagamentoId(_venda.FormaDePagamentoId)
                .WithUsuario(_venda.Usuario)
                .WithUsuarioId(_venda.UsuarioId)
                .WithValorTotal(_venda.ValorTotal)
                .Build();

            return venda;
        }

        public VendaDomain CriarParaExcluir(VendaDto vendaDto)
        {
            var _venda = Context.Vendas.FirstOrDefault(x => x.Id == vendaDto.Id);

            if (_venda == null) throw new ArgumentNullException(nameof(_venda));

            var venda = new VendaBuilder()
                .WithId(_venda.Id)
                .WithCliente(_venda.Cliente)
                .WithClienteId(_venda.ClienteId)
                .WithFormaDePagamento(_venda.FormaDePagamento)
                .WithFormaDePagamentoId(_venda.FormaDePagamentoId)
                .WithUsuario(_venda.Usuario)
                .WithUsuarioId(_venda.UsuarioId)
                .WithValorTotal(_venda.ValorTotal)
                .Build();

            return venda;
        }
    }
}
