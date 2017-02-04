using System.Data.Entity.ModelConfiguration;
using FrenteDeCaixa.Domain.DocumentoDeIdentificacao;
using FrenteDeCaixa.Resources;

namespace FrenteDeCaixa.Infrastructure.ContextConfigs
{
    public class DocumentoDeIdentificacaoConfig : EntityTypeConfiguration<DocumentoDeIdentificacaoDomain>
    {
        public DocumentoDeIdentificacaoConfig()
        {
            HasKey(x => x.Id);
            ToTable(Strings.DocumentoDeIdentificacaoDB);

            Property(x => x.Documento).IsRequired();
        }
    }
}
