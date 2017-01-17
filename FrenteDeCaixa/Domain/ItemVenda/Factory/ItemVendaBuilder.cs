using System;
using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Venda;

namespace FrenteDeCaixa.Domain.ItemVenda.Factory
{
    public class ItemVendaBuilder : IItemVendaBuilder
    {
        public Guid Id { get; set; }
        public Guid? VendaId { get; set; }
        public VendaDomain Venda { get; set; }
        public Guid? ProdutoId { get; set; }
        public ProdutoDomain Produto { get; set; }
        public int Quantidade { get; set; }
        public bool Excluido { get; set; }

        public ItemVendaBuilder WithId(Guid id)
        {
            Id = id;
            return this;
        }

        public ItemVendaBuilder WithProduto(ProdutoDomain produto)
        {
            Produto = produto;
            return this;
        }

        public ItemVendaBuilder WithProdutoId(Guid? produtoId)
        {
            ProdutoId = produtoId;
            return this;
        }

        public ItemVendaBuilder WithQuantidade(int quantidade)
        {
            Quantidade = quantidade;
            return this;
        }

        public ItemVendaBuilder WithVenda(VendaDomain venda)
        {
            Venda = venda;
            return this;
        }

        public ItemVendaBuilder WithVendaId(Guid? vendaId)
        {
            VendaId = vendaId;
            return this;
        }

        public ItemVendaBuilder WithExcluido(bool excluido)
        {
            Excluido = excluido;
            return this;
        }

        public ItemVendaDomain Build()
        {
            return new ItemVendaDomain (Id, VendaId, Venda, ProdutoId, Produto, Quantidade, Excluido);
        }
    }
}
