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
    public class UsuarioConfig : EntityTypeConfiguration<UsuarioDomain>
    {
        public UsuarioConfig()
        {
            HasKey(x => x.Id);
            ToTable(Strings.UsuarioDB);

            Property(x => x.Login).IsRequired();
            Property(x => x.Senha).IsRequired();
            Property(x => x.Nome).IsRequired();
            HasRequired(x => x.Perfil);
        }
    }
}
