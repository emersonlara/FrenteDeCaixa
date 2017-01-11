using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.Venda.Dto;
using FrenteDeCaixa.Domain.Venda;

namespace FrenteDeCaixa.Application.Service.Venda
{
    interface IVendaService
    {
        IVendaDto Salvar(VendaDto venda);
        void Alterar(VendaDomain venda);
        void Excluir(VendaDomain venda);
        List<VendaDomain> Listar();
        VendaDomain CriarParaSalvar(VendaDto vendaDto);
    }
}
