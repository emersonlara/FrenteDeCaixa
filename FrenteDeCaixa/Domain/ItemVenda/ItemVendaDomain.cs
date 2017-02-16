using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Venda;
using System;

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

        public ItemVendaDomain() { }

        public ItemVendaDomain(Guid id, Guid? vendaId, VendaDomain venda, Guid? produtoId, ProdutoDomain produto, int quantidade)
        {
            Id = id;
            VendaId = vendaId;
            Venda = venda;
            ProdutoId = produtoId;
            Produto = produto;
            Quantidade = quantidade;
        }
    }
}
