using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.Cliente.Dto;
using FrenteDeCaixa.Domain.Cliente;

namespace FrenteDeCaixa.Application.Service.Cliente
{
    interface IClienteService
    {
        IClienteDto Salvar(ClienteDto clienteDto);
        IClienteDto Alterar(ClienteDto clienteDto);
        void Excluir(ClienteDomain cliente);
        List<ClienteDomain> Listar();
    }
}
