using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service
{
    class PerfilDeUsuarioService : IPerfilDeUsuarioService
    {
        private EntidadesContext Banco { get; }

        public PerfilDeUsuarioService()
        {
            Banco = new EntidadesContext();
        }

        public void Salvar(PerfilDeUsuarioDomain perfil)
        {
            Banco.PerfisDeUsuarios.Add(perfil);
            Banco.SaveChanges();
        }

        public void Alterar(PerfilDeUsuarioDomain perfil)
        {
            var perfilAux = Banco.PerfisDeUsuarios.First(x => x.Id == perfil.Id);
            perfilAux.Nome = perfil.Nome;
            Banco.SaveChanges();
        }

        public void Excluir(PerfilDeUsuarioDomain perfil)
        {
            Banco.Set<PerfilDeUsuarioDomain>().Remove(perfil);
            Banco.SaveChanges();
        }

        public List<PerfilDeUsuarioDomain> Listar()
        {
            return (from c in Banco.PerfisDeUsuarios select c).ToList();
        }
    }
}
