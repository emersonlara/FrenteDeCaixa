using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Context;
using FrenteDeCaixa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrenteDeCaixa.Domain.Interface;
namespace FrenteDeCaixa.Application.Service
{
    class ItemVendaService : IItemVendaService
    {
        private EntidadesContext Banco;

        public ItemVendaService()
        {
            Banco = new EntidadesContext();
        }

        public void Salvar(ItemVenda item)
        {
            Banco.ItensVendas.Add(item);
            Banco.SaveChanges();
        }

        public void Alterar(ItemVenda item)
        {
            ItemVenda itemAux = Banco.ItensVendas
                .Where(x => x.Id == x.Id).First();
            itemAux.ProdutoId = item.ProdutoId;
            itemAux.Produto = item.Produto;
            itemAux.Quantidade = item.Quantidade;
            Banco.SaveChanges();
        }

        public void Excluir(ItemVenda item)
        {
            Banco.Set<ItemVenda>().Remove(item);
            Banco.SaveChanges();
        }

        public List<ItemVenda> Listar()
        {
            return (from c in Banco.ItensVendas select c).ToList();
        }
    }
}
