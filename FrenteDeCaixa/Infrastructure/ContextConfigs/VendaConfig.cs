using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.Venda;
using FrenteDeCaixa.Resources;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Infrastructure.ContextConfigs
{
    public class VendaConfig : EntityTypeConfiguration<VendaDomain>
    {
        public VendaConfig()
        {
            HasKey(x => x.Id);
            ToTable(Strings.VendaDB);

            Property(x => x.ValorTotal).IsRequired();
            HasRequired(x => x.Usuario);
            HasRequired(x => x.FormaDePagamento);
        }
    }
}
