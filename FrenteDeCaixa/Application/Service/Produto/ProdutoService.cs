using System;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Application.Service.Produto.Dto;
using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Produto.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service.Produto
{
    class ProdutoService : IProdutoService
    {
        private EntidadesContext Banco { get; }

        public ProdutoService()
        {
            Banco = new EntidadesContext();
        }

        public IProdutoDto Salvar(ProdutoDto produtoDto)
        {
            if (produtoDto == null)
            {
                return new ProdutoDto();
            }

            var produto = CriarParaSalvar(produtoDto);

            Banco.Produtos.Add(produto);
            Banco.SaveChanges();

            return produtoDto;
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

        public ProdutoDomain CriarParaSalvar(ProdutoDto produtoDto)
        {
            var produto = new ProdutoBuilder()
                .WithId(Guid.NewGuid())
                .WithNome(produtoDto.Nome)
                .WithFornecedor(produtoDto.Fornecedor)
                .WithFornecedorId(produtoDto.FornecedorId)
                .WithPreco(produtoDto.Preco)
                .WithQuantidade(produtoDto.Quantidade)
                .Build();

            return produto;
        }
    }
}
