using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Context;
using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service
{
    class ProdutoService : IProdutosService
    {
        private EntidadesContext Banco;

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
            ProdutoDomain produtoAux = Banco.Produtos
                .Where(x => x.Id == produto.Id).First();
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
