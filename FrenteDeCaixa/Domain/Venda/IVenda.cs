using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.Venda
{
    interface IVenda
    {
        Guid Id { get; set; }
        Guid? UsuarioId { get; set; }
        UsuarioDomain Usuario { get; set; }
        Guid? ClienteId { get; set; }
        ClienteDomain Cliente { get; set; }
        Guid? FormaDePagamentoId { get; set; }
        FormaDePagamentoDomain FormaDePagamento { get; set; }
        decimal ValorTotal { get; set; }
    }
}
