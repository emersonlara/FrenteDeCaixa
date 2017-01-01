using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.Interface
{
    interface IVenda
    {
        Guid Id { get; set; }
        Guid? UsuarioId { get; set; }
        Usuario Usuario { get; set; }
        Guid? ClienteId { get; set; }
        Cliente Cliente { get; set; }
        Guid? FormaDePagamentoId { get; set; }
        FormaDePagamento FormaDePagamento { get; set; }
        decimal ValorTotal { get; set; }
    }
}
