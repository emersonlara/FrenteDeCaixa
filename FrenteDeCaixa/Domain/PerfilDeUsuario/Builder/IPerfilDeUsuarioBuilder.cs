using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario.Builder
{
    interface IPerfilDeUsuarioBuilder
    {
        PerfilDeUsuarioBuilder WithId(Guid Id);
        PerfilDeUsuarioBuilder WithNome(string Nome);
        PerfilDeUsuarioDomain Build();
    }
}
