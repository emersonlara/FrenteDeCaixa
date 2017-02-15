using System;
using System.Data.Entity.Migrations;
using System.Linq;
using FrenteDeCaixa.Domain.PerfilDeUsuario.Factory;
using FrenteDeCaixa.Domain.Usuario.Factory;

namespace FrenteDeCaixa.Infrastructure.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context.EntidadesContext>
    {
        public Configuration()
        {
            //MigrationsDirectory = "Infrastructure/Migrations";
             AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context.EntidadesContext context)
        {
            var perfilEntidadeDomain = new PerfilDeUsuarioBuilder()
                .WithId(Guid.NewGuid())
                .WithNome("Administrador")
                .Build();
            context.PerfisDeUsuarios.Add(perfilEntidadeDomain);
            context.SaveChanges();

            var perfil = context.PerfisDeUsuarios.FirstOrDefault(x => x.Nome == "Administrador");
            if (perfil != null)
            {
                var usuario = new UsuarioBuilder()
                    .WithId(Guid.NewGuid())
                    .WithLogin("jfrode")
                    .WithNome("João Felipe Gonçalves")
                    .WithPerfil(perfil)
                    .WithPerfilId(perfil.Id)
                    .WithSenha("123")
                    .Build();

                context.Usuarios.Add(usuario);
            }
            context.SaveChanges();
        }
    }
}
