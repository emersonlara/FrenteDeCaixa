using FrenteDeCaixa.Domain.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.Produto
{
    interface IProduto
    {
        Guid Id { get; set; }
        string Nome { get; set; }
        Guid? FornecedorId { get; set; }
        ClienteDomain Fornecedor { get; set; }
        int Quantidade { get; set; }
        decimal Preco { get; set; }
    }
}
