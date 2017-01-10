using System;
using System.Data.Entity.Migrations;
using System.Linq;
using FrenteDeCaixa.Domain.PerfilDeUsuario.Factory;
using FrenteDeCaixa.Domain.Usuario.Factory;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Infrastructure.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EntidadesContext>
    {
        private readonly EntidadesContext _currentContext;

        public Configuration(EntidadesContext currentContext)
        {
            _currentContext = currentContext;
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntidadesContext context)
        {
            GeraPerfil();
            GeraUsuario();
        }

        public void GeraUsuario()
        {
            var perfil = _currentContext.PerfisDeUsuarios.FirstOrDefault(x => x.Nome == "Administrador");
            var usuario = new UsuarioBuilder()
            .WithId(Guid.NewGuid())
            .WithLogin("jfrode")
            .WithNome("João Felipe Gonçalves")
            .WithPerfil(perfil)
            .WithPerfilId(perfil.Id)
            .WithSenha("123")
            .Build();

            _currentContext.Usuarios.Add(usuario);
            _currentContext.SaveChanges();
        }

        public void GeraPerfil()
        {
            var perfilEntidadeDomain = new PerfilDeUsuarioBuilder()
                .WithId(Guid.NewGuid())
                .WithNome("Administrador")
                .Build();
            _currentContext.PerfisDeUsuarios.Add(perfilEntidadeDomain);
            _currentContext.SaveChanges();
        }
    }
}
