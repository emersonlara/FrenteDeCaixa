using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.ItemVenda.Dto;
using FrenteDeCaixa.Domain.ItemVenda;

namespace FrenteDeCaixa.Application.Service.ItemVenda
{
    public interface IItemVendaService
    {
        IItemVendaDto Salvar(ItemVendaDto itemVenda);
        void Alterar(ItemVendaDomain itemVenda);
        void Excluir(ItemVendaDomain itemVenda);
        List<ItemVendaDomain> Listar();
        ItemVendaDomain CriarParaSalvar(ItemVendaDto itemVendaDto);
    }
}
