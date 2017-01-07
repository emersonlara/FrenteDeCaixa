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

        public VendaDomain(Guid Id, Guid? UsuarioId, UsuarioDomain Usuario, Guid? ClienteId, 
            ClienteDomain Cliente, Guid? FormaDePagamentoId, FormaDePagamentoDomain FormaDePagamento, decimal ValorTotal)
        {
            this.Id = Id;
            this.UsuarioId = UsuarioId;
            this.Usuario = Usuario;
            this.ClienteId = ClienteId;
            this.Cliente = Cliente;
            this.FormaDePagamentoId = FormaDePagamentoId;
            this.FormaDePagamento = FormaDePagamento;
            this.ValorTotal = ValorTotal;
        }
    }
}
