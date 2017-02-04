using System;
using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;

namespace FrenteDeCaixa.Application.Service.Cliente.Dto
{
    public class ClienteDto : IClienteDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DocumentoDeIdentificacaoDomain DocumentoDeIdentificacao { get; set; }
        public string Tipo { get; set; }
        public bool Excluido { get; set; }
    }
}
