using FrenteDeCaixa.Context;
using FrenteDeCaixa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application
{
    class ClienteApplication
    {
        private EntidadesContext Banco;

        public ClienteApplication()
        {
            Banco = new EntidadesContext();
        }

        public void Salvar(Cliente cliente)
        {
            Banco.Clientes.Add(cliente);
            Banco.SaveChanges();
        }

        public void Alterar(Cliente cliente)
        {
            Cliente clienteAux = Banco.Clientes
                .Where(x => x.Id == cliente.Id).First();
            clienteAux.Nome = cliente.Nome;
            clienteAux.CpfCnpj = cliente.CpfCnpj;
            clienteAux.Tipo = cliente.Tipo;
            Banco.SaveChanges();
        }

        public void Excluir(Cliente cliente)
        {
            Banco.Set<Cliente>().Remove(cliente);
            Banco.SaveChanges();
        }

        public IEnumerable<Cliente> Listar()
        {
            return from c in Banco.Clientes select c;
        }
    }
}
