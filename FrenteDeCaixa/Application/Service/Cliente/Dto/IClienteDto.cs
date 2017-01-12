using System;
using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;

namespace FrenteDeCaixa.Application.Service.Cliente.Dto
{
    public interface IClienteDto
    {
        Guid Id { get; }
        string Nome { get; }
        DocumentoDeIdentificacaoDomain DocumentoDeIdentificacao { get; }
        string Tipo { get; }
        bool Excluido { get; }
    }
}
