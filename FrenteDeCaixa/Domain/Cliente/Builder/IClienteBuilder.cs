using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.Cliente.Builder
{
    interface IClienteBuilder
    {
        ClienteBuilder WithId(Guid Id);
        ClienteBuilder WithNome(string Nome);
        ClienteBuilder WithDocumentoDeIdentificacao(
            DocumentoDeIdentificacaoDomain DocumentoDeIdentificacao);
        ClienteBuilder WithTipo(string Tipo);
        ClienteDomain Build();
    }
}
