using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.Interface
{
    interface IItemVenda
    {
        Guid Id { get; set; }
        Guid? VendaId { get; set; }
        Venda Venda { get; set; }
        Guid? ProdutoId { get; set; }
        Produto Produto { get; set; }
        int Quantidade { get; set; }
    }
}
