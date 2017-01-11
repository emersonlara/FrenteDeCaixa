using System;
using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Venda;

namespace FrenteDeCaixa.Application.Service.ItemVenda.Dto
{
    public interface IItemVendaDto
    {
        Guid Id { get; }
        Guid? VendaId { get; }
        VendaDomain Venda { get; }
        Guid? ProdutoId { get; }
        ProdutoDomain Produto { get; }
        int Quantidade { get; }
    }
}
