using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FrenteDeCaixa.Application.Service.Produto.Dto;
using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Produto.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service.Produto
{
    public class ProdutoService : IProdutoService
    {
        private EntidadesContext Context { get; }

        public ProdutoService()
        {
            Context = new EntidadesContext();
        }

        public IProdutoDto Salvar(ProdutoDto produtoDto)
        {
            if (produtoDto == null) return new ProdutoDto();

            var produto = CriarParaSalvar(produtoDto);

            Context.Produtos.Add(produto);
            Context.SaveChanges();

            return produtoDto;
        }

        public IProdutoDto Alterar(ProdutoDto produtoDto)
        {
            if (produtoDto == null) return new ProdutoDto();

            var produto = CriarParaAlterar(produtoDto);

            Context.Entry(produto).State = EntityState.Modified;
            Context.SaveChanges();

            return produtoDto;
        }

        public IProdutoDto Excluir(ProdutoDto produtoDto)
        {
            if (produtoDto == null) return new ProdutoDto();

            var produto = CriarParaExcluir(produtoDto);

            Context.Entry(produto).State = EntityState.Modified;
            Context.SaveChanges();

            return produtoDto;
        }

        public List<ProdutoDomain> Listar()
        {
            return (from c in Context.Produtos select c).ToList();
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
                .WithExcluido(false)
                .Build();

            return produto;
        }

        public ProdutoDomain CriarParaAlterar(ProdutoDto produtoDto)
        {
            var _produto = Context.Produtos.FirstOrDefault(x => x.Id == produtoDto.Id);

            if (_produto == null) throw new ArgumentNullException(nameof(_produto));

            var produto = new ProdutoBuilder()
                .WithId(_produto.Id)
                .WithFornecedor(_produto.Fornecedor)
                .WithFornecedorId(_produto.FornecedorId)
                .WithNome(_produto.Nome)
                .WithPreco(_produto.Preco)
                .WithQuantidade(_produto.Quantidade)
                .WithExcluido(_produto.Excluido)
                .Build();

            return produto;
        }

        public ProdutoDomain CriarParaExcluir(ProdutoDto produtoDto)
        {
            var _produto = Context.Produtos.FirstOrDefault(x => x.Id == produtoDto.Id);

            if (_produto == null) throw new ArgumentNullException(nameof(_produto));

            var produto = new ProdutoBuilder()
                .WithId(_produto.Id)
                .WithFornecedor(_produto.Fornecedor)
                .WithFornecedorId(_produto.FornecedorId)
                .WithNome(_produto.Nome)
                .WithPreco(_produto.Preco)
                .WithQuantidade(_produto.Quantidade)
                .WithExcluido(true)
                .Build();

            return produto;
        }
    }
}
