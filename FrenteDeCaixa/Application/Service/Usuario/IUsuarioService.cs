using System.Collections.Generic;
using FrenteDeCaixa.Application.Service.Usuario.Dto;
using FrenteDeCaixa.Domain.Usuario;

namespace FrenteDeCaixa.Application.Service.Usuario
{
    public interface IUsuarioService
    {
        IUsuarioDto Salvar(UsuarioDto usuario);
        IUsuarioDto Alterar(UsuarioDto usuario);
        IUsuarioDto Excluir(UsuarioDto usuario);
        List<UsuarioDomain> Listar();
        UsuarioDomain CriarParaSalvar(UsuarioDto usuarioDto);
        UsuarioDomain CriarParaAlterar(UsuarioDto usuarioDto);
        UsuarioDomain CriarParaExcluir(UsuarioDto usuarioDto);
    }
}
