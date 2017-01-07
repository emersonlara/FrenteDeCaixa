using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Context;
using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service
{
    class ClienteService : IClienteService
    {
        private EntidadesContext Banco;

        public ClienteService()
        {
            Banco = new EntidadesContext();
        }

        public void Salvar(ClienteDomain cliente)
        {
            Banco.Clientes.Add(cliente);
            Banco.SaveChanges();
        }

        public void Alterar(ClienteDomain cliente)
        {
            ClienteDomain clienteAux = Banco.Clientes
                .Where(x => x.Id == cliente.Id).First();
            clienteAux.Nome = cliente.Nome;
            clienteAux.DocumentoDeIdentificacao = cliente.DocumentoDeIdentificacao;
            clienteAux.Tipo = cliente.Tipo;
            Banco.SaveChanges();
        }

        public void Excluir(ClienteDomain cliente)
        {
            Banco.Set<ClienteDomain>().Remove(cliente);
            Banco.SaveChanges();
        }

        public List<ClienteDomain> Listar()
        {
            return (from c in Banco.Clientes select c).ToList();
        }
    }
}
