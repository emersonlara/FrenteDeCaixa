using System;
using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Venda;

namespace FrenteDeCaixa.Domain.ItemVenda.Factory
{
    interface IItemVendaBuilder
    {
        ItemVendaBuilder WithId(Guid id);
        ItemVendaBuilder WithVendaId(Guid? vendaId);
        ItemVendaBuilder WithVenda(VendaDomain venda);
        ItemVendaBuilder WithProdutoId(Guid? produtoId);
        ItemVendaBuilder WithProduto(ProdutoDomain produto);
        ItemVendaBuilder WithQuantidade(int quantidade);
        ItemVendaDomain Build();
    }
}
