using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Model
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid? FornecedorId { get; set; }
        public Cliente Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
