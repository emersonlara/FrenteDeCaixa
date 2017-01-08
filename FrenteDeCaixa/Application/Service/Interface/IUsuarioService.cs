using FrenteDeCaixa.Domain.Usuario;
using System.Collections.Generic;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IUsuarioService
    {
        void Salvar(UsuarioDomain usuario);
        void Alterar(UsuarioDomain usuario);
        void Excluir(UsuarioDomain usuario);
        List<UsuarioDomain> Listar();
    }
}
