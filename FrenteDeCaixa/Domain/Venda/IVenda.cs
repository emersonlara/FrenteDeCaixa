using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.Usuario;
using System;

namespace FrenteDeCaixa.Domain.Venda
{
    public interface IVenda
    {
        Guid Id { get; set; }
        Guid? UsuarioId { get; set; }
        UsuarioDomain Usuario { get; set; }
        Guid? ClienteId { get; set; }
        ClienteDomain Cliente { get; set; }
        Guid? FormaDePagamentoId { get; set; }
        FormaDePagamentoDomain FormaDePagamento { get; set; }
        decimal ValorTotal { get; set; }
        bool Excluido { get; set; }
    }
}
