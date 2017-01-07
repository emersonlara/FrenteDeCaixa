using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.Cliente
{
    interface ICliente
    {
        Guid Id { get; set; }
        string Nome { get; set; }
        DocumentoDeIdentificacaoDomain DocumentoDeIdentificacao { get; set; }
        string Tipo { get; set; }
    }
}
