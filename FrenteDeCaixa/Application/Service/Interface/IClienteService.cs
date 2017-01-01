using FrenteDeCaixa.Context;
using FrenteDeCaixa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IClienteService
    {
        void Salvar(Cliente cliente);
        void Alterar(Cliente cliente);
        void Excluir(Cliente cliente);
        List<Cliente> Listar();
    }
}
