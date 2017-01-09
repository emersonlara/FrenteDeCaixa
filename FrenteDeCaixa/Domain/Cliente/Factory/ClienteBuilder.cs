using System;
using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;

namespace FrenteDeCaixa.Domain.Cliente.Builder
{
    public class ClienteBuilder : IClienteBuilder
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DocumentoDeIdentificacaoDomain DocumentoDeIdentificacao { get; set; }
        public string Tipo { get; set; }

        public ClienteBuilder WithId(Guid id)
        {
            Id = id;
            return this;
        }

        public ClienteBuilder WithNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ClienteBuilder WithDocumentoDeIdentificacao(DocumentoDeIdentificacaoDomain documentoDeIdentificacao)
        {
            DocumentoDeIdentificacao = documentoDeIdentificacao;
            return this;
        }

        public ClienteBuilder WithTipo(string tipo)
        {
            Tipo = tipo;
            return this;
        }

        public ClienteDomain Build()
        {
            return new ClienteDomain(Id, Nome, DocumentoDeIdentificacao, Tipo);
        }
    }
}
