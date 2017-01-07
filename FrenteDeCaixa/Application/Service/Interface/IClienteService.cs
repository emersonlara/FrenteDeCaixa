using FrenteDeCaixa.Context;
using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
