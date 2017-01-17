using FrenteDeCaixa.Domain.Cliente;
using System;

namespace FrenteDeCaixa.Domain.Produto
{
    public class ProdutoDomain : IProduto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid? FornecedorId { get; set; }
        public ClienteDomain Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public bool Excluido { get; set; }

        public ProdutoDomain(Guid id, string nome, Guid? fornecedorId, ClienteDomain fornecedor, int quantidade, decimal preco, bool excluido)
        {
            Id = id;
            Nome = nome;
            FornecedorId = fornecedorId;
            Fornecedor = fornecedor;
            Quantidade = quantidade;
            Preco = preco;
            Excluido = excluido;
        }
    }
}
