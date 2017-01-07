using FrenteDeCaixa.Domain.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario
{
    interface IVenda
    {
        Guid Id { get; set; }
        Guid? UsuarioId { get; set; }
        Usuario Usuario { get; set; }
        Guid? ClienteId { get; set; }
        ClienteDomain Cliente { get; set; }
        Guid? FormaDePagamentoId { get; set; }
        FormaDePagamento FormaDePagamento { get; set; }
        decimal ValorTotal { get; set; }
    }
}
