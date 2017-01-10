using System;
using FrenteDeCaixa.Domain.Cliente;

namespace FrenteDeCaixa.Domain.Produto.Factory
{
    class ProdutoBuilder : IProdutoBuilder
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid? FornecedorId { get; set; }
        public ClienteDomain Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public ProdutoBuilder WithId(Guid id)
        {
            Id = id;
            return this;
        }

        public ProdutoBuilder WithNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ProdutoBuilder WithFornecedorId(Guid? fornecedorId)
        {
            FornecedorId = fornecedorId;
            return this;
        }

        public ProdutoBuilder WithFornecedor(ClienteDomain fornecedor)
        {
            Fornecedor = fornecedor;
            return this;
        }

        public ProdutoBuilder WithQuantidade(int quantidade)
        {
            Quantidade = quantidade;
            return this;
        }

        public ProdutoBuilder WithPreco(decimal preco)
        {
            Preco = preco;
            return this;
        }

        public ProdutoDomain Build()
        {
            return new ProdutoDomain(Id, Nome, FornecedorId, Fornecedor, Quantidade, Preco);
        }
    }
}
