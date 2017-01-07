using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.FormaDePagamento
{
    interface IFormaDePagamento
    {
        Guid Id { get; set; }
        string Nome { get; set; }
    }
}
