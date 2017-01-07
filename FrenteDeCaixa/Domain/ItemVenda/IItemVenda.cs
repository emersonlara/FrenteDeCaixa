using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.ItemVenda
{
    interface IItemVenda
    {
        Guid Id { get; set; }
        Guid? VendaId { get; set; }
        VendaDomain Venda { get; set; }
        Guid? ProdutoId { get; set; }
        ProdutoDomain Produto { get; set; }
        int Quantidade { get; set; }
    }
}
