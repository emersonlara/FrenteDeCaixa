using System;
using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.Usuario;

namespace FrenteDeCaixa.Application.Service.Venda.Dto
{
    public interface IVendaDto
    {
        Guid Id { get; }
        Guid? UsuarioId { get; }
        UsuarioDomain Usuario { get; }
        Guid? ClienteId { get; }
        ClienteDomain Cliente { get; }
        Guid? FormaDePagamentoId { get; }
        FormaDePagamentoDomain FormaDePagamento { get; }
        decimal ValorTotal { get; }
    }
}
