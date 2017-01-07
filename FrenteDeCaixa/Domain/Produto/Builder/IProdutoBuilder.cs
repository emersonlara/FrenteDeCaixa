using FrenteDeCaixa.Domain.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.Produto.Builder
{
    interface IProdutoBuilder
    {
        ProdutoBuilder WithId(Guid Id);
        ProdutoBuilder WithNome(string Nome);
        ProdutoBuilder WithFornecedorId(Guid? FornecedorId);
        ProdutoBuilder WithFornecedor(ClienteDomain Fornecedor);
        ProdutoBuilder WithQuantidade(int Quantidade);
        ProdutoBuilder WithPreco(decimal Preco);
        ProdutoDomain Build();
    }
}
