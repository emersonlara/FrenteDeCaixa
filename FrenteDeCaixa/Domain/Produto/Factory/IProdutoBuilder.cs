using System;
using FrenteDeCaixa.Domain.Cliente;

namespace FrenteDeCaixa.Domain.Produto.Factory
{
    public interface IProdutoBuilder
    {
        ProdutoBuilder WithId(Guid id);
        ProdutoBuilder WithNome(string nome);
        ProdutoBuilder WithFornecedorId(Guid? fornecedorId);
        ProdutoBuilder WithFornecedor(ClienteDomain fornecedor);
        ProdutoBuilder WithQuantidade(int quantidade);
        ProdutoBuilder WithPreco(decimal preco);
        ProdutoBuilder WithExcluido(bool excluido);
        ProdutoDomain Build();
    }
}
