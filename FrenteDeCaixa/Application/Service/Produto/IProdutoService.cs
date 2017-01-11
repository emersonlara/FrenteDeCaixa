using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.Produto.Dto;
using FrenteDeCaixa.Domain.Produto;

namespace FrenteDeCaixa.Application.Service.Produto
{
    interface IProdutoService
    {
        IProdutoDto Salvar(ProdutoDto produto);
        void Alterar(ProdutoDomain produto);
        void Excluir(ProdutoDomain produto);
        List<ProdutoDomain> Listar();
        ProdutoDomain CriarParaSalvar(ProdutoDto produtoDto);
    }
}
