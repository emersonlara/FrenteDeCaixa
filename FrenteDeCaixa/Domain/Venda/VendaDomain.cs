using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.Usuario;
using System;

namespace FrenteDeCaixa.Domain.Venda
{
    public class VendaDomain : IVenda
    {
        public Guid Id { get; set; }
        public Guid? UsuarioId { get; set; }
        public UsuarioDomain Usuario { get; set; }
        public Guid? ClienteId { get; set; }
        public ClienteDomain Cliente { get; set; }
        public Guid? FormaDePagamentoId { get; set; }
        public FormaDePagamentoDomain FormaDePagamento { get; set; }
        public decimal ValorTotal { get; set; }

        public VendaDomain(Guid id, Guid? usuarioId, UsuarioDomain usuario, Guid? clienteId, 
            ClienteDomain cliente, Guid? formaDePagamentoId, FormaDePagamentoDomain formaDePagamento, decimal valorTotal)
        {
            Id = id;
            UsuarioId = usuarioId;
            Usuario = usuario;
            ClienteId = clienteId;
            Cliente = cliente;
            FormaDePagamentoId = formaDePagamentoId;
            FormaDePagamento = formaDePagamento;
            ValorTotal = valorTotal;
        }
    }
}
