using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;
using System;

namespace FrenteDeCaixa.Domain.Cliente
{
    public interface ICliente
    {
        Guid Id { get; set; }
        string Nome { get; set; }
        //DocumentoDeIdentificacaoDomain DocumentoDeIdentificacao { get; set; }
        string Tipo { get; set; }
        bool Excluido { get; }
    }
}
