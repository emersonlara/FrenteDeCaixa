namespace FrenteDeCaixa.Migrations
{
    using Application;
    using Application.Service;
    using Domain;
    using Domain.Usuario;
    using Domain.Usuario.Builder;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FrenteDeCaixa.Context.EntidadesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FrenteDeCaixa.Context.EntidadesContext context)
        {
            UsuarioService usuarioService = new UsuarioService();
            UsuarioBuilder usuarioBuilder = new UsuarioBuilder();
            /*
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
