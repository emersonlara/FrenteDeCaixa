using System;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Application.Service.ItemVenda.Dto;
using FrenteDeCaixa.Domain.ItemVenda;
using FrenteDeCaixa.Domain.ItemVenda.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service.ItemVenda
{
    public class ItemVendaService : IItemVendaService
    {
        private EntidadesContext Banco { get; }

        public ItemVendaService()
        {
            Banco = new EntidadesContext();
        }

        public IItemVendaDto Salvar(ItemVendaDto itemVendaDto)
        {
            if (itemVendaDto == null)
            {
                return new ItemVendaDto();
            }

            var itemVenda = CriarParaSalvar(itemVendaDto);

            Banco.ItensVendas.Add(itemVenda);
            Banco.SaveChanges();

            return itemVendaDto;
        }

        public void Alterar(ItemVendaDomain item)
        {
            var itemAux = Banco.ItensVendas.First(x => x.Id == item.Id);
            itemAux.ProdutoId = item.ProdutoId;
            itemAux.Produto = item.Produto;
            itemAux.Quantidade = item.Quantidade;
            Banco.SaveChanges();
        }

        public void Excluir(ItemVendaDomain item)
        {
            Banco.Set<ItemVendaDomain>().Remove(item);
            Banco.SaveChanges();
        }

        public List<ItemVendaDomain> Listar()
        {
            return (from c in Banco.ItensVendas select c).ToList();
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
    }
}
