using System;

namespace FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto
{
    public class PerfilDeUsuarioDto : IPerfilDeUsuarioDto
    {
        public Guid Id { get; }
        public string Nome { get; }
    }
}
