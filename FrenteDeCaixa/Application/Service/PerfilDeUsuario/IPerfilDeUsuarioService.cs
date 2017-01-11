using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Application.Service.PerfilDeUsuario
{
    interface IPerfilDeUsuarioService
    {
        IPerfilDeUsuarioDto Salvar(PerfilDeUsuarioDto perfilDeUsuario);
        void Alterar(PerfilDeUsuarioDomain perfilDeUsuario);
        void Excluir(PerfilDeUsuarioDomain perfilDeUsuario);
        List<PerfilDeUsuarioDomain> Listar();
        PerfilDeUsuarioDomain CriarParaSalvar(PerfilDeUsuarioDto perfilDeUsuarioDto);
    }
}
