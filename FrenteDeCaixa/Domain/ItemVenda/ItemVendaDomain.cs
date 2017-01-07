using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.ItemVenda
{
    public class ItemVendaDomain : IItemVenda
    {
        public Guid Id { get; set; }
        public Guid? VendaId { get; set; }
        public VendaDomain Venda { get; set; }
        public Guid? ProdutoId { get; set; }
        public ProdutoDomain Produto { get; set; }
        public int Quantidade { get; set; }

        public ItemVendaDomain(Guid Id, Guid? VendaId, VendaDomain Venda, Guid? ProdutoId, ProdutoDomain Produto, int Quantidade)
        {
            this.Id = Id;
            this.VendaId = VendaId;
            this.Venda = Venda;
            this.ProdutoId = ProdutoId;
            this.Produto = Produto;
            this.Quantidade = Quantidade;
        }
    }
}
