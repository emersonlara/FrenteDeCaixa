using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;
using System;

namespace FrenteDeCaixa.Domain.Cliente.Builder
{
    interface IClienteBuilder
    {
        ClienteBuilder WithId(Guid id);
        ClienteBuilder WithNome(string nome);
        ClienteBuilder WithDocumentoDeIdentificacao(
            DocumentoDeIdentificacaoDomain documentoDeIdentificacao);
        ClienteBuilder WithTipo(string tipo);
        ClienteDomain Build();
    }
}
