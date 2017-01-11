using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.Usuario.Dto;
using FrenteDeCaixa.Domain.Usuario;

namespace FrenteDeCaixa.Application.Service.Usuario
{
    interface IUsuarioService
    {
        IUsuarioDto Salvar(UsuarioDto usuario);
        void Alterar(UsuarioDomain usuario);
        void Excluir(UsuarioDomain usuario);
        List<UsuarioDomain> Listar();
        UsuarioDomain CriarParaSalvar(UsuarioDto usuarioDto);
    }
}
