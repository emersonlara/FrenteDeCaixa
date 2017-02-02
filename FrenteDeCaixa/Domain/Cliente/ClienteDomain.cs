using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;
using System;

namespace FrenteDeCaixa.Domain.Cliente
{
    public class ClienteDomain : ICliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        //public DocumentoDeIdentificacaoDomain DocumentoDeIdentificacao { get; set; }
        public string Tipo { get; set; }
        public bool Excluido { get; set; }

        public ClienteDomain(Guid id, string nome, DocumentoDeIdentificacaoDomain documentoDeIdentificacao, string tipo, bool excluido)
        {
            Id = id;
            Nome = nome;
            //DocumentoDeIdentificacao = documentoDeIdentificacao;
            Tipo = tipo;
            Excluido = excluido;
        }
    }
}
