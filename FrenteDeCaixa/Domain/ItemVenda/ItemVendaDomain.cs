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
        public Venda Venda { get; set; }
        public Guid? ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public ItemVendaDomain(Guid Id, Guid? VendaId, Venda Venda, Guid? ProdutoId, Produto Produto, int Quantidade)
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
