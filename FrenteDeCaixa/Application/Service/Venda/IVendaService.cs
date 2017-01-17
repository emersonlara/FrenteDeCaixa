using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.Venda.Dto;
using FrenteDeCaixa.Domain.Venda;

namespace FrenteDeCaixa.Application.Service.Venda
{
    public interface IVendaService
    {
        IVendaDto Salvar(VendaDto venda);
        IVendaDto Alterar(VendaDto venda);
        IVendaDto Excluir(VendaDto venda);
        List<VendaDomain> Listar();
        VendaDomain CriarParaSalvar(VendaDto vendaDto);
        VendaDomain CriarParaAlterar(VendaDto vendaDto);
        VendaDomain CriarParaExcluir(VendaDto vendaDto);
    }
}
