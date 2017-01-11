using System;
using FrenteDeCaixa.Domain.Cliente;

namespace FrenteDeCaixa.Application.Service.Produto.Dto
{
    public class ProdutoDto : IProdutoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid? FornecedorId { get; set; }
        public ClienteDomain Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
