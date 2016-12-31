using FrenteDeCaixa.Context;
using FrenteDeCaixa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service
{
    class VendaService
    {
        private EntidadesContext Banco { get; set; }

        public VendaService()
        {
            Banco = new EntidadesContext();
        }

        public void Salvar(Venda venda)
        {
            Banco.Vendas.Add(venda);
            Banco.SaveChanges();
        }

        public void Alterar(Venda venda)
        {
            Venda vendaAux = Banco.Vendas
                .Where(x => x.Id == venda.Id).First();
            vendaAux.UsuarioId = venda.UsuarioId;
            vendaAux.Usuario = venda.Usuario;
            vendaAux.ClienteId = venda.ClienteId;
            vendaAux.Cliente = venda.Cliente;
            vendaAux.FormaDePagamentoId = venda.FormaDePagamentoId;
            vendaAux.FormaDePagamento = venda.FormaDePagamento;
            vendaAux.ValorTotal = venda.ValorTotal;
        }

        public void Excluir(Venda venda)
        {
            Banco.Set<Venda>().Remove(venda);
            Banco.SaveChanges();
        }

        public List<Venda> Listar()
        {
            return (from c in Banco.Vendas select c).ToList();
        }
    }
}
