using FrenteDeCaixa.Domain.FormaDePagamento;
using FrenteDeCaixa.Resources;
using System.Data.Entity.ModelConfiguration;

namespace FrenteDeCaixa.Infrastructure.ContextConfigs
{
    public class FormaDePagamentoConfig : EntityTypeConfiguration<FormaDePagamentoDomain>
    {
        public FormaDePagamentoConfig()
        {
            HasKey(x => x.Id);
            ToTable(Strings.FormaDePagamentoDB);

            Property(x => x.Nome).IsRequired();
        }
    }
}
