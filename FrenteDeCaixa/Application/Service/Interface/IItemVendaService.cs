using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IItemVendaService
    {
        void Salvar(ItemVenda itemVenda);
        void Alterar(ItemVenda itemVenda);
        void Excluir(ItemVenda itemVenda);
        List<IItemVenda> Listar();
    }
}
