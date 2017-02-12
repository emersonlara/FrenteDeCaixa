using System;

namespace FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto
{
    public class PerfilDeUsuarioDto : IPerfilDeUsuarioDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Excluido { get; set; }
    }
}
