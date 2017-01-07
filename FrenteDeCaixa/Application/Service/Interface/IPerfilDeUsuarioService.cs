using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IPerfilDeUsuarioService
    {
        void Salvar(PerfilDeUsuarioDomain perfilDeUsuario);
        void Alterar(PerfilDeUsuarioDomain perfilDeUsuario);
        void Excluir(PerfilDeUsuarioDomain perfilDeUsuario);
        List<PerfilDeUsuarioDomain> Listar();
    }
}
