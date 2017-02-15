using System;
using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;

namespace FrenteDeCaixa.Domain.Cliente.Factory
{
    public interface IClienteBuilder
    {
        ClienteBuilder WithId(Guid id);
        ClienteBuilder WithNome(string nome);
        ClienteBuilder WithDocumentoDeIdentificacao(
            DocumentoDeIdentificacaoDomain documentoDeIdentificacao);
        ClienteBuilder WithTipo(string tipo);
        ClienteDomain Build();
    }
}
