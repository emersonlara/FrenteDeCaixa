using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.Cliente
{
    public class ClienteDomain : ICliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DocumentoDeIdentificacaoDomain DocumentoDeIdentificacao { get; set; }
        public string Tipo { get; set; }

        public ClienteDomain(Guid Id, string Nome, DocumentoDeIdentificacaoDomain DocumentoDeIdentificacao, string Tipo)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.DocumentoDeIdentificacao = DocumentoDeIdentificacao;
            this.Tipo = Tipo;
        }
    }
}
