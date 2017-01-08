using FrenteDeCaixa.Domain.PerfilDeUsuario;
using System.Collections.Generic;

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
