using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.Cliente.Dto;
using FrenteDeCaixa.Domain.Cliente;

namespace FrenteDeCaixa.Application.Service.Cliente
{
    interface IClienteService
    {
        IClienteDto Salvar(ClienteDto clienteDto);
        void Alterar(ClienteDomain cliente);
        void Excluir(ClienteDomain cliente);
        List<ClienteDomain> Listar();
    }
}
