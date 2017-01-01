using FrenteDeCaixa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IPerfilDeUsuarioService
    {
        void Salvar(PerfilDeUsuario perfilDeUsuario);
        void Alterar(PerfilDeUsuario perfilDeUsuario);
        void Excluir(PerfilDeUsuario perfilDeUsuario);
        List<PerfilDeUsuario> Listar();
    }
}
