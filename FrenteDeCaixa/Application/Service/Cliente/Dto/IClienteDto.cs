using System;
using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;

namespace FrenteDeCaixa.Application.Service.Cliente.Dto
{
    public interface IClienteDto
    {
        Guid Id { get; }
        string Nome { get; }
        DocumentoDeIdentificacaoDomain DocumentoDeIdentificacao { get; }
        string Tipo { get; }
        ClienteDomain CriarParaSalvar(ClienteDto clienteDto);
    }
}
