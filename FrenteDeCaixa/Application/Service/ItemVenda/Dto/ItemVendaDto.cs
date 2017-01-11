using System;
using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Venda;

namespace FrenteDeCaixa.Application.Service.ItemVenda.Dto
{
    public class ItemVendaDto : IItemVendaDto
    {
        public Guid Id { get; set; }
        public Guid? VendaId { get; set; }
        public VendaDomain Venda { get; set; }
        public Guid? ProdutoId { get; set; }
        public ProdutoDomain Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
