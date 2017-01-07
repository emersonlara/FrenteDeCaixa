using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                //.HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));
        }
    }
}
