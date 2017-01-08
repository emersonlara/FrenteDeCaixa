using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Domain.Venda;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service
{
    class VendaService : IVendaService
    {
        private EntidadesContext Banco { get; }

        public VendaService()
        {
            Banco = new EntidadesContext();
        }

        public void Salvar(VendaDomain venda)
        {
            Banco.Vendas.Add(venda);
            Banco.SaveChanges();
        }

        public void Alterar(VendaDomain venda)
        {
            var vendaAux = Banco.Vendas.First(x => x.Id == venda.Id);
            vendaAux.UsuarioId = venda.UsuarioId;
            vendaAux.Usuario = venda.Usuario;
            vendaAux.ClienteId = venda.ClienteId;
            vendaAux.Cliente = venda.Cliente;
            vendaAux.FormaDePagamentoId = venda.FormaDePagamentoId;
            vendaAux.FormaDePagamento = venda.FormaDePagamento;
            vendaAux.ValorTotal = venda.ValorTotal;
        }

        public void Excluir(VendaDomain venda)
        {
            Banco.Set<VendaDomain>().Remove(venda);
            Banco.SaveChanges();
        }

        public List<VendaDomain> Listar()
        {
            return (from c in Banco.Vendas select c).ToList();
        }
    }
}
