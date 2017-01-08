using System.Data.Entity.Migrations;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Infrastructure.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EntidadesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntidadesContext context)
        {
            /*
            UsuarioService usuarioService = new UsuarioService();
            UsuarioBuilder usuarioBuilder = new UsuarioBuilder();
            
            UsuarioDomain usuario = new UsuarioDomain()
            {
                Id = Guid.NewGuid(),
                Login = "jfrode",
                Senha = "123",
                Nome = "João Felipe Gonçalves"
            };
            usuarioService.Salvar(usuario);*/
        }
    }
}
