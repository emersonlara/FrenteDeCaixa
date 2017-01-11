using System;
using FrenteDeCaixa.Domain.PerfilDeUsuario;

namespace FrenteDeCaixa.Application.Service.Usuario.Dto
{
    public class UsuarioDto : IUsuarioDto
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public Guid? PerfilId { get; set; }
        public PerfilDeUsuarioDomain Perfil { get; set; }
    }
}
