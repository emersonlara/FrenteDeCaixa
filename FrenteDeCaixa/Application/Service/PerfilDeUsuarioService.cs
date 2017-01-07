using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Context;
using FrenteDeCaixa.Domain;
using FrenteDeCaixa.Domain.PerfilDeUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service
{
    class PerfilDeUsuarioService : IPerfilDeUsuarioService
    {
        private EntidadesContext Banco;

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
            PerfilDeUsuarioDomain perfilAux = Banco.PerfisDeUsuarios
                .Where(x => x.Id == perfil.Id).First();
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
