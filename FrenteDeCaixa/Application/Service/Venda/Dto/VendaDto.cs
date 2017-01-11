using System;
using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.Usuario;

namespace FrenteDeCaixa.Application.Service.Venda.Dto
{
    public class VendaDto : IVendaDto
    {
        public Guid Id { get; set; }
        public Guid? UsuarioId { get; set; }
        public UsuarioDomain Usuario { get; set; }
        public Guid? ClienteId { get; set; }
        public ClienteDomain Cliente { get; set; }
        public Guid? FormaDePagamentoId { get; set; }
        public FormaDePagamentoDomain FormaDePagamento { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
