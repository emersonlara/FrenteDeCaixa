using FrenteDeCaixa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IVendaService
    {
        void Salvar(Venda venda);
        void Alterar(Venda venda);
        void Excluir(Venda venda);
        List<Venda> Listar();
    }
}
