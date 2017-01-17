using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.ItemVenda.Dto;
using FrenteDeCaixa.Domain.ItemVenda;

namespace FrenteDeCaixa.Application.Service.ItemVenda
{
    public interface IItemVendaService
    {
        IItemVendaDto Salvar(ItemVendaDto itemVenda);
        IItemVendaDto Alterar(ItemVendaDto itemVenda);
        IItemVendaDto Excluir(ItemVendaDto itemVenda);
        List<ItemVendaDomain> Listar();
        ItemVendaDomain CriarParaSalvar(ItemVendaDto itemVendaDto);
        ItemVendaDomain CriarParaAlterar(ItemVendaDto itemVendaDto);
        ItemVendaDomain CriarParaExcluir(ItemVendaDto itemVendaDto);
    }
}
