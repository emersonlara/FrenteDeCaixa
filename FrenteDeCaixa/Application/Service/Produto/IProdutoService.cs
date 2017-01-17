using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.Produto.Dto;
using FrenteDeCaixa.Domain.Produto;

namespace FrenteDeCaixa.Application.Service.Produto
{
    public interface IProdutoService
    {
        IProdutoDto Salvar(ProdutoDto produto);
        IProdutoDto Alterar(ProdutoDto produto);
        IProdutoDto Excluir(ProdutoDto produto);
        List<ProdutoDomain> Listar();
        ProdutoDomain CriarParaSalvar(ProdutoDto produtoDto);
        ProdutoDomain CriarParaAlterar(ProdutoDto produtoDto);
        ProdutoDomain CriarParaExcluir(ProdutoDto produtoDto);
    }
}
