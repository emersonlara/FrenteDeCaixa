using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FrenteDeCaixa.Application.Service.ItemVenda.Dto;
using FrenteDeCaixa.Domain.ItemVenda;
using FrenteDeCaixa.Domain.ItemVenda.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service.ItemVenda
{
    public class ItemVendaService : IItemVendaService
    {
        private EntidadesContext Context { get; }

        public ItemVendaService()
        {
            Context = new EntidadesContext();
        }

        public IItemVendaDto Salvar(ItemVendaDto itemVendaDto)
        {
            if (itemVendaDto == null)
            {
                return new ItemVendaDto();
            }

            var itemVenda = CriarParaSalvar(itemVendaDto);

            Context.ItensVendas.Add(itemVenda);
            Context.SaveChanges();

            return itemVendaDto;
        }

        public IItemVendaDto Alterar(ItemVendaDto itemVendaDto)
        {
            if (itemVendaDto == null) return new ItemVendaDto();

            var itemVenda = CriarParaAlterar(itemVendaDto);

            Context.Entry(itemVenda).State = EntityState.Modified;
            Context.SaveChanges();

            return itemVendaDto;
        }

        public IItemVendaDto Excluir(ItemVendaDto itemVendaDto)
        {
            if (itemVendaDto == null) return new ItemVendaDto();

            var itemVenda = CriarParaExcluir(itemVendaDto);

            Context.Entry(itemVenda).State = EntityState.Modified;
            Context.SaveChanges();

            return itemVendaDto;
        }

        public List<ItemVendaDomain> Listar()
        {
            return (from c in Context.ItensVendas select c).ToList();
        }

        public ItemVendaDomain CriarParaSalvar(ItemVendaDto itemVendaDto)
        {
            var itemVenda = new ItemVendaBuilder()
                .WithId(Guid.NewGuid())
                .WithVenda(itemVendaDto.Venda)
                .WithVendaId(itemVendaDto.VendaId)
                .WithProduto(itemVendaDto.Produto)
                .WithProdutoId(itemVendaDto.ProdutoId)
                .WithQuantidade(itemVendaDto.Quantidade)
                .WithVendaId(itemVendaDto.VendaId)
                .Build();

            return itemVenda;
        }

        public ItemVendaDomain CriarParaAlterar(ItemVendaDto itemVendaDto)
        {
            var _itemVenda = Context.ItensVendas.FirstOrDefault(x => x.Id == itemVendaDto.Id);

            if (_itemVenda == null) throw new ArgumentNullException(nameof(_itemVenda));

            var itemVenda = new ItemVendaBuilder()
                .WithId(_itemVenda.Id)
                .WithProduto(_itemVenda.Produto)
                .WithProdutoId(_itemVenda.ProdutoId)
                .WithQuantidade(_itemVenda.Quantidade)
                .WithVenda(_itemVenda.Venda)
                .WithVendaId(_itemVenda.VendaId)
                .Build();

            return itemVenda;
        }

        public ItemVendaDomain CriarParaExcluir(ItemVendaDto itemVendaDto)
        {
            var _itemVenda = Context.ItensVendas.FirstOrDefault(x => x.Id == itemVendaDto.Id);

            if (_itemVenda == null) throw new ArgumentNullException(nameof(_itemVenda));

            var itemVenda = new ItemVendaBuilder()
                .WithId(_itemVenda.Id)
                .WithProduto(_itemVenda.Produto)
                .WithProdutoId(_itemVenda.ProdutoId)
                .WithQuantidade(_itemVenda.Quantidade)
                .WithVenda(_itemVenda.Venda)
                .WithVendaId(_itemVenda.VendaId)                
                .Build();

            return itemVenda;
        }
    }
}
