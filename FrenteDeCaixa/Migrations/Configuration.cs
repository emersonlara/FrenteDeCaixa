using FrenteDeCaixa.Domain.PerfilDeUsuario.Factory;
using FrenteDeCaixa.Domain.Usuario.Factory;

namespace FrenteDeCaixa.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FrenteDeCaixa.Infrastructure.Context.EntidadesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FrenteDeCaixa.Infrastructure.Context.EntidadesContext context)
        {
            var perfilEntidadeDomain = new PerfilDeUsuarioBuilder()
                .WithId(Guid.NewGuid())
                .WithNome("Administrador")
                .Build();
            context.PerfisDeUsuarios.Add(perfilEntidadeDomain);
            context.SaveChanges();

            var perfil = context.PerfisDeUsuarios.FirstOrDefault(x => x.Nome == "Administrador");
            var usuario = new UsuarioBuilder()
            .WithId(Guid.NewGuid())
            .WithLogin("jfrode")
            .WithNome("João Felipe Gonçalves")
            .WithPerfil(perfil)
            .WithPerfilId(perfil.Id)
            .WithSenha("123")
            .Build();

            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }
    }
}
