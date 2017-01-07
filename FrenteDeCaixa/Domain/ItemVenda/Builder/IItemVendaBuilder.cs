﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.ItemVenda.Builder
{
    interface IItemVendaBuilder
    {
        ItemVendaBuilder WithId(Guid Id);
        ItemVendaBuilder WithVendaId(Guid? VendaId);
        ItemVendaBuilder WithVenda(Venda Venda);
        ItemVendaBuilder WithProdutoId(Guid? ProdutoId);
        ItemVendaBuilder WithProduto(Produto Produto);
        ItemVendaBuilder WithQuantidade(int Quantidade);
        ItemVendaDomain Build();
    }
}