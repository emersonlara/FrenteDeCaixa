using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.Cliente.Dto;
using FrenteDeCaixa.Domain.Cliente;

namespace FrenteDeCaixa.Application.Service.Cliente
{
    public interface IClienteService
    {
        IClienteDto Salvar(ClienteDto clienteDto);
        IClienteDto Alterar(ClienteDto clienteDto);
        IClienteDto Excluir(ClienteDto cliente);
        List<ClienteDomain> Listar();
        ClienteDomain CriarParaSalvar(ClienteDto clienteDto);
        ClienteDomain CriarParaAlterar(ClienteDto clienteDto);
    }
}
