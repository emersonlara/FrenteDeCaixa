using FrenteDeCaixa.Domain.Cliente;
using System;

namespace FrenteDeCaixa.Domain.Produto.Builder
{
    interface IProdutoBuilder
    {
        ProdutoBuilder WithId(Guid id);
        ProdutoBuilder WithNome(string nome);
        ProdutoBuilder WithFornecedorId(Guid? fornecedorId);
        ProdutoBuilder WithFornecedor(ClienteDomain fornecedor);
        ProdutoBuilder WithQuantidade(int quantidade);
        ProdutoBuilder WithPreco(decimal preco);
        ProdutoDomain Build();
    }
}
