using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Resources;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Infrastructure.ContextConfigs
{
    public class ItemVendaConfig : EntityTypeConfiguration<ItemVenda>
    {
        public ItemVendaConfig()
        {
            HasKey(x => x.Id);
            ToTable(Strings.ItemVendaDB);

            Property(x => x.Quantidade).IsRequired();
            HasRequired(x => x.Produto);
        }
    }
}
