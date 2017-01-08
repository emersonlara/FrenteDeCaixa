using FrenteDeCaixa.Application.Service.Interface;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Domain.ItemVenda;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service
{
    class ItemVendaService : IItemVendaService
    {
        private EntidadesContext Banco { get; }

        public ItemVendaService()
        {
            Banco = new EntidadesContext();
        }

        public void Salvar(ItemVendaDomain item)
        {
            Banco.ItensVendas.Add(item);
            Banco.SaveChanges();
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
    }
}
