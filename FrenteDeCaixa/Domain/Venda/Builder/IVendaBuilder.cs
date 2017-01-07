using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.Venda.Builder
{
    interface IVendaBuilder
    {
        VendaBuilder WithId(Guid Id);
        VendaBuilder WithUsuarioId(Guid? UsuarioId);
        VendaBuilder WithUsuario(UsuarioDomain Usuario);
        VendaBuilder WithClienteId(Guid? ClienteId);
        VendaBuilder WithCliente(ClienteDomain Cliente);
        VendaBuilder WithFormaDePagamentoId(Guid? FormaDePagamentoId);
        VendaBuilder WithFormaDePagamento(FormaDePagamentoDomain FormaDePagamento);
        VendaBuilder WithValorTotal(decimal ValorTotal);
        VendaDomain Build();
    }
}
