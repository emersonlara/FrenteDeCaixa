using FrenteDeCaixa.Domain.Produto;
using FrenteDeCaixa.Resources;
using System.Data.Entity.ModelConfiguration;

namespace FrenteDeCaixa.Infrastructure.ContextConfigs
{
    public class ProdutoConfig : EntityTypeConfiguration<ProdutoDomain>
    {
        public ProdutoConfig()
        {
            HasKey(x => x.Id);
            ToTable(Strings.ProdutoDB);

            Property(x => x.Nome).IsRequired();
            Property(x => x.Quantidade).IsRequired();
            Property(x => x.Preco).IsRequired();
            Property(x => x.Excluido).IsRequired();

            // HasRequired(x => x.Fornecedor); Produto de producao propria
        }
    }
}
