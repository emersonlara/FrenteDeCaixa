using System;
using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.Usuario;

namespace FrenteDeCaixa.Domain.Venda.Factory
{
    public interface IVendaBuilder
    {
        VendaBuilder WithId(Guid id);
        VendaBuilder WithUsuarioId(Guid? usuarioId);
        VendaBuilder WithUsuario(UsuarioDomain usuario);
        VendaBuilder WithClienteId(Guid? clienteId);
        VendaBuilder WithCliente(ClienteDomain cliente);
        VendaBuilder WithFormaDePagamentoId(Guid? formaDePagamentoId);
        VendaBuilder WithFormaDePagamento(FormaDePagamentoDomain formaDePagamento);
        VendaBuilder WithValorTotal(decimal valorTotal);
        VendaBuilder WithExcluido(bool excluido);
        VendaDomain Build();
    }
}
