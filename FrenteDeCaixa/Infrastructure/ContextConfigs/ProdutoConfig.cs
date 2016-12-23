using FrenteDeCaixa.Model;
using FrenteDeCaixa.Resources;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Infrastructure.ContextConfigs
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(x => x.Id);
            ToTable(Strings.ProdutoDB);

            Property(x => x.Nome).IsRequired();
            Property(x => x.Quantidade).IsRequired();
            Property(x => x.Preco).IsRequired();

            // HasRequired(x => x.Fornecedor); Produto de producao propria
        }
    }
}
