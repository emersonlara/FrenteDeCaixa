using System;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Application.Service.Venda.Dto;
using FrenteDeCaixa.Domain.Venda;
using FrenteDeCaixa.Domain.Venda.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service.Venda
{
    class VendaService : IVendaService
    {
        private EntidadesContext Banco { get; }

        public VendaService()
        {
            Banco = new EntidadesContext();
        }

        public IVendaDto Salvar(VendaDto vendaDto)
        {
            if (vendaDto == null)
            {
                return new VendaDto();
            }
            var venda = CriarParaSalvar(vendaDto);

            Banco.Vendas.Add(venda);
            Banco.SaveChanges();

            return vendaDto;
        }

        public void Alterar(VendaDomain venda)
        {
            var vendaAux = Banco.Vendas.First(x => x.Id == venda.Id);
            vendaAux.UsuarioId = venda.UsuarioId;
            vendaAux.Usuario = venda.Usuario;
            vendaAux.ClienteId = venda.ClienteId;
            vendaAux.Cliente = venda.Cliente;
            vendaAux.FormaDePagamentoId = venda.FormaDePagamentoId;
            vendaAux.FormaDePagamento = venda.FormaDePagamento;
            vendaAux.ValorTotal = venda.ValorTotal;
        }

        public void Excluir(VendaDomain venda)
        {
            Banco.Set<VendaDomain>().Remove(venda);
            Banco.SaveChanges();
        }

        public List<VendaDomain> Listar()
        {
            return (from c in Banco.Vendas select c).ToList();
        }

        public VendaDomain CriarParaSalvar(VendaDto vendaDto)
        {
            var venda = new VendaBuilder()
                .WithId(Guid.NewGuid())
                .WithCliente(vendaDto.Cliente)
                .WithClienteId(vendaDto.ClienteId)
                .WithFormaDePagamento(vendaDto.FormaDePagamento)
                .WithFormaDePagamentoId(vendaDto.FormaDePagamentoId)
                .WithUsuario(vendaDto.Usuario)
                .WithUsuarioId(vendaDto.UsuarioId)
                .WithValorTotal(vendaDto.ValorTotal)
                .Build();

            return venda;
        }
    }
}
