using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain
{
    public class Venda : IVenda
    {
        public Guid Id { get; set; }
        public Guid? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public Guid? ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Guid? FormaDePagamentoId { get; set; }
        public FormaDePagamento FormaDePagamento { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
