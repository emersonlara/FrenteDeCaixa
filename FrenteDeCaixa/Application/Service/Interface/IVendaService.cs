using FrenteDeCaixa.Domain.Venda;
using System.Collections.Generic;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IVendaService
    {
        void Salvar(VendaDomain venda);
        void Alterar(VendaDomain venda);
        void Excluir(VendaDomain venda);
        List<VendaDomain> Listar();
    }
}
