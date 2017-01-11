using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto
{
    public interface IPerfilDeUsuarioDto
    {
        Guid Id { get; }
        string Nome { get; }
    }
}
