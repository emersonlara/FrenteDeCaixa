using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;

namespace FrenteDeCaixa.Domain.Cliente.Builder
{
    class ClienteBuilder : IClienteBuilder
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DocumentoDeIdentificacaoDomain DocumentoDeIdentificacao { get; set; }
        public string Tipo { get; set; }

        public ClienteBuilder WithId(Guid Id)
        {
            this.Id = Id;
            return this;
        }

        public ClienteBuilder WithNome(string Nome)
        {
            this.Nome = Nome;
            return this;
        }

        public ClienteBuilder WithDocumentoDeIdentificacao(DocumentoDeIdentificacaoDomain DocumentoDeIdentificacao)
        {
            this.DocumentoDeIdentificacao = DocumentoDeIdentificacao;
            return this;
        }

        public ClienteBuilder WithTipo(string Tipo)
        {
            this.Tipo = Tipo;
            return this;
        }

        public ClienteDomain Build()
        {
            return new ClienteDomain(Id, Nome, DocumentoDeIdentificacao, Tipo);
        }
    }
}
