using System;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Application.Service.Cliente.Dto;
using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.Cliente.Factory;
using FrenteDeCaixa.Infrastructure.Context;
using System.Data.Entity;

namespace FrenteDeCaixa.Application.Service.Cliente
{
    public class ClienteService : IClienteService
    {
        private EntidadesContext Context { get; }

        public ClienteService()
        {
            Context = new EntidadesContext();
        }

        public IClienteDto Salvar(ClienteDto clienteDto)
        {
            if (clienteDto == null) return new ClienteDto();

            // TODO aqui chamar o validator do Dto

            var cliente = CriarParaSalvar(clienteDto);

            Context.Clientes.Add(cliente);
            Context.SaveChanges();

            return clienteDto;
        }

        public IClienteDto Alterar(ClienteDto clienteDto)
        {
            if (clienteDto == null) return new ClienteDto();

            // TODO aqui chamar o validator do Dto

            var cliente = CriarParaAlterar(clienteDto);

            // TODO valida a instancia

            Context.Entry(cliente).State = EntityState.Modified;
            Context.SaveChanges();

            return clienteDto;
        }

        public IClienteDto Excluir(ClienteDto clienteDto)
        {
            if (clienteDto == null) return new ClienteDto();

            var cliente = CriarParaExcluir(clienteDto);

            Context.Entry(cliente).State = EntityState.Modified;
            Context.SaveChanges();

            return clienteDto;
        }

        public List<ClienteDomain> Listar()
        {
            return (from c in Context.Clientes select c).ToList();
        }

        public ClienteDomain CriarParaSalvar(ClienteDto clienteDto)
        {
            var cliente = new ClienteBuilder()
                .WithNome(clienteDto.Nome)
                .WithDocumentoDeIdentificacao(clienteDto.DocumentoDeIdentificacao)
                .WithId(Guid.NewGuid())
                .WithTipo(clienteDto.Tipo)
                .Build();

            return cliente;
        }

        public ClienteDomain CriarParaAlterar(ClienteDto clienteDto)
        {
            var _cliente = Context.Clientes.FirstOrDefault(x => x.Id == clienteDto.Id);

            if (_cliente == null) throw new ArgumentNullException(nameof(_cliente));

            var cliente = new ClienteBuilder()
                .WithNome(_cliente.Nome)
                //.WithDocumentoDeIdentificacao(_cliente.DocumentoDeIdentificacao)
                .WithId(_cliente.Id)
                .WithTipo(_cliente.Tipo)
                .Build();

            return cliente;
        }

        public ClienteDomain CriarParaExcluir(ClienteDto clienteDto)
        {
            var _cliente = Context.Clientes.FirstOrDefault(x => x.Id == clienteDto.Id);

            if (_cliente == null) throw new ArgumentNullException(nameof(_cliente));

            var cliente = new ClienteBuilder()
                .WithNome(_cliente.Nome)
                //.WithDocumentoDeIdentificacao(_cliente.DocumentoDeIdentificacao)
                .WithId(_cliente.Id)
                .WithTipo(_cliente.Tipo)
                .Build();

            return cliente;
        }
    }
}
