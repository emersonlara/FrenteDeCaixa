using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain
{
    public class ProdutoDomain : IProduto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid? FornecedorId { get; set; }
        public ClienteDomain Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public ProdutoDomain(Guid Id, string Nome, Guid? FornecedorId, ClienteDomain Fornecedor, int Quantidade, decimal Preco)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.FornecedorId = FornecedorId;
            this.Fornecedor = Fornecedor;
            this.Quantidade = Quantidade;
            this.Preco = Preco;
        }
    }
}
