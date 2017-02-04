using System.Data.Entity;
using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.ItemVenda;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Usuario;
using FrenteDeCaixa.Domain.Venda;

namespace FrenteDeCaixa.Infrastructure.Context
{
    public class EntidadesContext : DbContext
    {
        public DbSet<UsuarioDomain> Usuarios { get; set; }
        public DbSet<FormaDePagamentoDomain> FormasDePagamentos { get; set; }
        public DbSet<PerfilDeUsuarioDomain> PerfisDeUsuarios { get; set; }
        public DbSet<ClienteDomain> Clientes { get; set; }
        public DbSet<VendaDomain> Vendas { get; set; }
        public DbSet<ItemVendaDomain> ItensVendas { get; set; }
        public DbSet<ProdutoDomain> Produtos { get; set; }
        public DbSet<DocumentoDeIdentificacaoDomain> DocumentoDeIdentificacao { get; set; }
    }
}
