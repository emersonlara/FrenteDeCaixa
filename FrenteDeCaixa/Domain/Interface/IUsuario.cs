using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.PerfilDeUsuario
{
    interface IUsuario
    {
        Guid Id { get; set; }
        string Login { get; set; }
        string Senha { get; set; }
        string Nome { get; set; }
        Guid? PerfilId { get; set; }
        PerfilDeUsuarioDomain Perfil { get; set; }
    }
}
