using FrenteDeCaixa.Domain.Cliente;
using FrenteDeCaixa.Resources;
using System.Data.Entity.ModelConfiguration;

namespace FrenteDeCaixa.Infrastructure.ContextConfigs
{
    public class ClienteConfig : EntityTypeConfiguration<ClienteDomain>
    {
        public ClienteConfig()
        {
            HasKey(x => x.Id);
            ToTable(Strings.ClienteDB);

            Property(x => x.Nome).IsRequired();
            Property(x => x.Tipo).IsRequired();
            //HasRequired(x => x.DocumentoDeIdentificacao);
        }
    }
}
