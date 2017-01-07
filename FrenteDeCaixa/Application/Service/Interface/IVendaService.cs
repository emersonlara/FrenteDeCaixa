using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
