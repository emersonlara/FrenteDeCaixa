

using System;

namespace FrenteDeCaixa.Domain.DocumentoDeIdentificacao
{
    public abstract class DocumentoDeIdentificacaoDomain
    {
        public Guid Id { get; set; }
        public string Documento { get; set; }
    }
}
