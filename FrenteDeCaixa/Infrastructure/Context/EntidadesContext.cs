
using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Domain.ItemVenda;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Domain.Usuario;
using FrenteDeCaixa.Domain.Venda;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Context
{
    class EntidadesContext : DbContext
    {
        public DbSet<UsuarioDomain> Usuarios { get; set; }
        public DbSet<FormaDePagamentoDomain> FormasDePagamentos { get; set; }
        public DbSet<PerfilDeUsuarioDomain> PerfisDeUsuarios { get; set; }
        public DbSet<ClienteDomain> Clientes { get; set; }
        public DbSet<VendaDomain> Vendas { get; set; }
        public DbSet<ItemVendaDomain> ItensVendas { get; set; }
        public DbSet<ProdutoDomain> Produtos { get; set; }
    }
}
