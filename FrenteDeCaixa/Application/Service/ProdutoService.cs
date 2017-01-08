using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Domain.Produto;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service
{
    class ProdutoService : IProdutosService
    {
        private EntidadesContext Banco { get; }

        public ProdutoService()
        {
            Banco = new EntidadesContext();
        }

        public void Salvar(ProdutoDomain produto)
        {
            Banco.Produtos.Add(produto);
            Banco.SaveChanges();
        }

        public void Alterar(ProdutoDomain produto)
        {
            var produtoAux = Banco.Produtos.First(x => x.Id == produto.Id);
            produtoAux.Nome = produto.Nome;
            produtoAux.FornecedorId = produto.FornecedorId;
            produtoAux.Fornecedor = produto.Fornecedor;
            produtoAux.Quantidade = produto.Quantidade;
            produtoAux.Preco = produto.Preco;
            Banco.SaveChanges();
        }

        public void Excluir(ProdutoDomain produto)
        {
            Banco.Set<ProdutoDomain>().Remove(produto);
            Banco.SaveChanges();
        }

        public List<ProdutoDomain> Listar()
        {
            return (from c in Banco.Produtos select c).ToList();
        }
    }
}
