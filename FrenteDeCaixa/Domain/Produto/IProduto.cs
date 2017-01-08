using FrenteDeCaixa.Domain.Cliente;
using System;

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
