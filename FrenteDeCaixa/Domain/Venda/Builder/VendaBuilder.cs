using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.Usuario;

namespace FrenteDeCaixa.Domain.Venda.Builder
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

        public VendaBuilder WithId(Guid Id)
        {
            this.Id = Id;
            return this;
        }

        public VendaBuilder WithUsuarioId(Guid? UsuarioId)
        {
            this.UsuarioId = UsuarioId;
            return this;
        }

        public VendaBuilder WithUsuario(UsuarioDomain Usuario)
        {
            this.Usuario = Usuario;
            return this;
        }

        public VendaBuilder WithClienteId(Guid? ClienteId)
        {
            this.ClienteId = ClienteId;
            return this;
        }

        public VendaBuilder WithCliente(ClienteDomain Cliente)
        {
            this.Cliente = Cliente;
            return this;
        }

        public VendaBuilder WithFormaDePagamentoId(Guid? FormaDePagamentoId)
        {
            this.FormaDePagamentoId = FormaDePagamentoId;
            return this;
        }

        public VendaBuilder WithFormaDePagamento(FormaDePagamentoDomain FormaDePagamento)
        {
            this.FormaDePagamento = FormaDePagamento;
            return this;
        }

        public VendaBuilder WithValorTotal(decimal ValorTotal)
        {
            this.ValorTotal = ValorTotal;
            return this;
        }

        public VendaDomain Build()
        {
            return new VendaDomain(Id, UsuarioId, Usuario, ClienteId,
            Cliente, FormaDePagamentoId, FormaDePagamento, ValorTotal);
        }
    }
}
