using FrenteDeCaixa.Domain.Usuario;
using FrenteDeCaixa.Resources;
using System.Data.Entity.ModelConfiguration;

namespace FrenteDeCaixa.Infrastructure.ContextConfigs
{
    public class UsuarioConfig : EntityTypeConfiguration<UsuarioDomain>
    {
        public UsuarioConfig()
        {
            HasKey(x => x.Id);
            ToTable(Strings.UsuarioDB);

            Property(x => x.Login).IsRequired();
            Property(x => x.Senha).IsRequired();
            Property(x => x.Nome).IsRequired();
            HasRequired(x => x.PerfilDeUsuarioDomain);
        }
    }
}
