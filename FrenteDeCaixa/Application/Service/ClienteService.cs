using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Domain.Cliente;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service
{
    class ClienteService : IClienteService
    {
        private EntidadesContext Banco { get; }

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
            var clienteAux = Banco.Clientes.First(x => x.Id == cliente.Id);
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
