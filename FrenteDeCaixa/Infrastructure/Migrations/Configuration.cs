using System;
using System.Data.Entity.Migrations;
using System.Linq;
using FrenteDeCaixa.Domain.PerfilDeUsuario.Factory;
using FrenteDeCaixa.Domain.Usuario.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Infrastructure.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<FrenteDeCaixa.Infrastructure.Context.EntidadesContext>
    {
        public Configuration()
        {
            this.MigrationsDirectory = "Infrastructure/Migrations";
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntidadesContext context)
        {
            var perfilEntidadeDomain = new PerfilDeUsuarioBuilder()
                .WithId(Guid.NewGuid())
                .WithNome("Administrador")
                .WithExcluido(false)
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
            .WithExcluido(false)
            .Build();

            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }
    }
}
