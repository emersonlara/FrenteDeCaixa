using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain
{
    public class ItemVenda : IItemVenda
    {
        public Guid Id { get; set; }
        public Guid? VendaId { get; set; }
        public Venda Venda { get; set; }
        public Guid? ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
