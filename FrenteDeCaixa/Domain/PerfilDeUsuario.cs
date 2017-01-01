using FrenteDeCaixa.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain
{
    public class PerfilDeUsuario : IPerfilDeUsuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
