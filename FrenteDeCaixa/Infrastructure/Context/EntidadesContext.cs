using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.Cliente;
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
        public DbSet<FormaDePagamento> FormasDePagamentos { get; set; }
        public DbSet<PerfilDeUsuarioDomain> PerfisDeUsuarios { get; set; }
        public DbSet<ClienteDomain> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemVendaDomain> ItensVendas { get; set; }
        public DbSet<ProdutoDomain> Produtos { get; set; }
    }
}
