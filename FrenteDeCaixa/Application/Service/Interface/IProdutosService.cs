using FrenteDeCaixa.Domain.Produto;
using System.Collections.Generic;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IProdutosService
    {
        void Salvar(ProdutoDomain produto);
        void Alterar(ProdutoDomain produto);
        void Excluir(ProdutoDomain produto);
        List<ProdutoDomain> Listar();
    }
}
