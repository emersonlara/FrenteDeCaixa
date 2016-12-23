using FrenteDeCaixa.Context;
using FrenteDeCaixa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application
{
    class ProdutoApplication
    {
        private EntidadesContext Banco;

        public ProdutoApplication()
        {
            Banco = new EntidadesContext();
        }

        public void Salvar(Produto produto)
        {
            Banco.Produtos.Add(produto);
            Banco.SaveChanges();
        }

        public void Alterar(Produto produto)
        {
            Produto produtoAux = Banco.Produtos
                .Where(x => x.Id == produto.Id).First();
            produtoAux.Nome = produto.Nome;
            produtoAux.FornecedorId = produto.FornecedorId;
            produtoAux.Fornecedor = produto.Fornecedor;
            produtoAux.Quantidade = produto.Quantidade;
            produtoAux.Preco = produto.Preco;
            Banco.SaveChanges();
        }

        public void Excluir(Produto produto)
        {
            Banco.Set<Produto>().Remove(produto);
            Banco.SaveChanges();
        }

        public IEnumerable<Produto> Listar()
        {
            return from c in Banco.Produtos select c;
        }
    }
}
