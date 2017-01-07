using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Context;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Domain.ItemVenda;

namespace FrenteDeCaixa.Application.Service
{
    class ItemVendaService : IItemVendaService
    {
        private EntidadesContext Banco;

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
            ItemVendaDomain itemAux = Banco.ItensVendas
                .Where(x => x.Id == x.Id).First();
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
