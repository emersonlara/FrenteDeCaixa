using FrenteDeCaixa.Domain.Cliente;
using System.Collections.Generic;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IClienteService
    {
        void Salvar(ClienteDomain cliente);
        void Alterar(ClienteDomain cliente);
        void Excluir(ClienteDomain cliente);
        List<ClienteDomain> Listar();
    }
}
