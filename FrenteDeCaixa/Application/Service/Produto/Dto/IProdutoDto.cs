using System;
using FrenteDeCaixa.Domain.Cliente;

namespace FrenteDeCaixa.Application.Service.Produto.Dto
{
    public interface IProdutoDto
    {
        Guid Id { get; }
        string Nome { get; }
        Guid? FornecedorId { get; }
        ClienteDomain Fornecedor { get; }
        int Quantidade { get; }
        decimal Preco { get; }
    }
}
