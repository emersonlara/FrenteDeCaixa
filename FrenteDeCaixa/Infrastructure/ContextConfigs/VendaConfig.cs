using FrenteDeCaixa.Domain.Venda;
using FrenteDeCaixa.Resources;
using System.Data.Entity.ModelConfiguration;

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
            Property(x => x.Excluido).IsRequired();
        }
    }
}
