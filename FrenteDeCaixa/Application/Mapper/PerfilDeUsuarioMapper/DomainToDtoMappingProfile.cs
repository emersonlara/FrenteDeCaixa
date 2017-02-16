using AutoMapper;
using FrenteDeCaixa.Application.Service.Cliente.Dto;
using FrenteDeCaixa.Application.Service.FormaDePagamento.Dto;
using FrenteDeCaixa.Application.Service.PerfilDeUsuario.Dto;
using FrenteDeCaixa.Application.Service.Produto.Dto;
using FrenteDeCaixa.Application.Service.Usuario.Dto;
using FrenteDeCaixa.Application.Service.Venda.Dto;
using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Usuario;
using FrenteDeCaixa.Domain.Venda;

namespace FrenteDeCaixa.Application.Mapper.PerfilDeUsuarioMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<PerfilDeUsuarioDomain, PerfilDeUsuarioDto>();
            CreateMap<UsuarioDomain, UsuarioDto>();
            CreateMap<ClienteDomain, ClienteDto>();
            CreateMap<ProdutoDomain, ProdutoDto>();
            CreateMap<FormaDePagamentoDomain, FormaDePagamentoDto>();
            CreateMap<VendaDomain, VendaDto>();
        }
    }
}
