using System;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Application.Service.Cliente.Dto;
using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.Cliente.Builder;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service.Cliente
{
    class ClienteService : IClienteService
    {
        private EntidadesContext Banco { get; }

        public ClienteService()
        {
            Banco = new EntidadesContext();
        }

        public IClienteDto Salvar(ClienteDto clienteDto)
        {
            if (clienteDto == null)
            {
                return new ClienteDto();
            }

            // TODO aqui chamar o validator do Dto

            var cliente = CriarParaSalvar(clienteDto);

            Banco.Clientes.Add(cliente);
            Banco.SaveChanges();

            return clienteDto;
        }

        private ClienteDomain CriarParaSalvar(ClienteDto clienteDto)
        {
            var cliente = new ClienteBuilder()
                .WithNome(clienteDto.Nome)
                .WithDocumentoDeIdentificacao(clienteDto.DocumentoDeIdentificacao)
                .WithId(Guid.NewGuid())
                .WithTipo(clienteDto.Tipo)
                .Build();

            return cliente;
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
