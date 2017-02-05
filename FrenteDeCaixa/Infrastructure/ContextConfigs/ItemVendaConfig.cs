using FrenteDeCaixa.Domain.ItemVenda;
using FrenteDeCaixa.Resources;
using System.Data.Entity.ModelConfiguration;

namespace FrenteDeCaixa.Infrastructure.ContextConfigs
{
    public class ItemVendaConfig : EntityTypeConfiguration<ItemVendaDomain>
    {
        public ItemVendaConfig()
        {
            HasKey(x => x.Id);
            ToTable(Strings.ItemVendaDB);

            Property(x => x.Quantidade).IsRequired();
            HasRequired(x => x.Produto);
            Property(x => x.Excluido).IsRequired();
        }
    }
}
