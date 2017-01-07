using FrenteDeCaixa.Domain.ItemVenda;
using System.Collections.Generic;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IItemVendaService
    {
        void Salvar(ItemVendaDomain itemVenda);
        void Alterar(ItemVendaDomain itemVenda);
        void Excluir(ItemVendaDomain itemVenda);
        List<ItemVendaDomain> Listar();
    }
}
