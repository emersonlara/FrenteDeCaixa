using FrenteDeCaixa.Domain.PerfilDeUsuario;
using FrenteDeCaixa.Resources;
using System.Data.Entity.ModelConfiguration;

namespace FrenteDeCaixa.Infrastructure.ContextConfigs
{
    public class PerfilDeUsuarioConfig : EntityTypeConfiguration<PerfilDeUsuarioDomain>
    {
        public PerfilDeUsuarioConfig()
        {
            HasKey(x => x.Id);
            ToTable(Strings.FormaDePagamentoDB);

            Property(x => x.Nome)
                .IsRequired();
        }
    }
}
