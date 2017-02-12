using FrenteDeCaixa.Application.Mapper.PerfilDeUsuarioMapper;

namespace FrenteDeCaixa.Application.Mapper
{
    public class AutoMapperConfig
    {
        public AutoMapperConfig()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DomainToDtoMappingProfile>();
                cfg.AddProfile<DtoToDomainMappingProfile>();
            });

            AutoMapper.Mapper.Configuration.CompileMappings();
        }
    }
}
