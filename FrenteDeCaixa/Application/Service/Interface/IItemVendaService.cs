using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
