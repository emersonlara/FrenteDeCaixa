using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrenteDeCaixa.Domain.Cliente;

namespace FrenteDeCaixa.Domain.Produto.Builder
{
    class ProdutoBuilder : IProdutoBuilder
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid? FornecedorId { get; set; }
        public ClienteDomain Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public ProdutoBuilder WithId(Guid Id)
        {
            this.Id = Id;
            return this;
        }

        public ProdutoBuilder WithNome(string Nome)
        {
            this.Nome = Nome;
            return this;
        }

        public ProdutoBuilder WithFornecedorId(Guid? FornecedorId)
        {
            this.FornecedorId = FornecedorId;
            return this;
        }

        public ProdutoBuilder WithFornecedor(ClienteDomain Fornecedor)
        {
            this.Fornecedor = Fornecedor;
            return this;
        }

        public ProdutoBuilder WithQuantidade(int Quantidade)
        {
            this.Quantidade = Quantidade;
            return this;
        }

        public ProdutoBuilder WithPreco(decimal Preco)
        {
            this.Preco = Preco;
            return this;
        }

        public ProdutoDomain Build()
        {
            return new ProdutoDomain(Id, Nome, FornecedorId, Fornecedor, Quantidade, Preco);
        }
    }
}
