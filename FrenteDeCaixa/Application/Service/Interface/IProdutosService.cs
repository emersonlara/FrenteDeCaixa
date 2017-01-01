using FrenteDeCaixa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IProdutosService
    {
        void Salvar(Produto produto);
        void Alterar(Produto produto);
        void Excluir(Produto produto);
        List<Produto> Listar();
    }
}
