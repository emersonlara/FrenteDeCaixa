using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Venda;
using System;

namespace FrenteDeCaixa.Domain.ItemVenda.Builder
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
