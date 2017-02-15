using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Venda;
using System;

namespace FrenteDeCaixa.Domain.ItemVenda
{
    public interface IItemVenda
    {
        Guid Id { get; set; }
        Guid? VendaId { get; set; }
        VendaDomain Venda { get; set; }
        Guid? ProdutoId { get; set; }
        ProdutoDomain Produto { get; set; }
        int Quantidade { get; set; }
    }
}
