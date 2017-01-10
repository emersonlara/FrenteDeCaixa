using System;
using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.Usuario;

namespace FrenteDeCaixa.Domain.Venda.Factory
{
    class VendaBuilder : IVendaBuilder
    {
        public Guid Id { get; set; }
        public Guid? UsuarioId { get; set; }
        public UsuarioDomain Usuario { get; set; }
        public Guid? ClienteId { get; set; }
        public ClienteDomain Cliente { get; set; }
        public Guid? FormaDePagamentoId { get; set; }
        public FormaDePagamentoDomain FormaDePagamento { get; set; }
        public decimal ValorTotal { get; set; }

        public VendaBuilder WithId(Guid id)
        {
            Id = id;
            return this;
        }

        public VendaBuilder WithUsuarioId(Guid? usuarioId)
        {
            UsuarioId = usuarioId;
            return this;
        }

        public VendaBuilder WithUsuario(UsuarioDomain usuario)
        {
            Usuario = usuario;
            return this;
        }

        public VendaBuilder WithClienteId(Guid? clienteId)
        {
            ClienteId = clienteId;
            return this;
        }

        public VendaBuilder WithCliente(ClienteDomain cliente)
        {
            Cliente = cliente;
            return this;
        }

        public VendaBuilder WithFormaDePagamentoId(Guid? formaDePagamentoId)
        {
            FormaDePagamentoId = formaDePagamentoId;
            return this;
        }

        public VendaBuilder WithFormaDePagamento(FormaDePagamentoDomain formaDePagamento)
        {
            FormaDePagamento = formaDePagamento;
            return this;
        }

        public VendaBuilder WithValorTotal(decimal valorTotal)
        {
            ValorTotal = valorTotal;
            return this;
        }

        public VendaDomain Build()
        {
            return new VendaDomain(Id, UsuarioId, Usuario, ClienteId,
            Cliente, FormaDePagamentoId, FormaDePagamento, ValorTotal);
        }
    }
}
