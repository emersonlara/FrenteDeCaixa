using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Application.Service.PerfilDeUsuario
{
    public interface IPerfilDeUsuarioService
    {
        IPerfilDeUsuarioDto Salvar(PerfilDeUsuarioDto perfilDeUsuario);
        IPerfilDeUsuarioDto Alterar(PerfilDeUsuarioDto perfilDeUsuarioDto);
        IPerfilDeUsuarioDto Excluir(PerfilDeUsuarioDto perfilDeUsuarioDto);
        List<PerfilDeUsuarioDomain> Listar();
        PerfilDeUsuarioDomain CriarParaSalvar(PerfilDeUsuarioDto perfilDeUsuarioDto);
        PerfilDeUsuarioDomain CriarParaAlterar(PerfilDeUsuarioDto perfilDeUsuarioDto);
        PerfilDeUsuarioDomain CriarParaExcluir(PerfilDeUsuarioDto perfilDeUsuarioDto);
    }
}
