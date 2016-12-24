using FrenteDeCaixa.Context;
using FrenteDeCaixa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application
{
    class PerfilDeUsuarioApplication
    {
        private EntidadesContext Banco;

        public PerfilDeUsuarioApplication()
        {
            Banco = new EntidadesContext();
        }

        public void Salvar(PerfilDeUsuario perfil)
        {
            Banco.PerfisDeUsuarios.Add(perfil);
            Banco.SaveChanges();
        }

        public void Alterar(PerfilDeUsuario perfil)
        {
            PerfilDeUsuario perfilAux = Banco.PerfisDeUsuarios
                .Where(x => x.Id == perfil.Id).First();
            perfilAux.Nome = perfil.Nome;
            Banco.SaveChanges();
        }

        public void Excluir(PerfilDeUsuario perfil)
        {
            Banco.Set<PerfilDeUsuario>().Remove(perfil);
            Banco.SaveChanges();
        }

        public IEnumerable<PerfilDeUsuario> Listar()
        {
            return from c in Banco.PerfisDeUsuarios select c;
        }
    }
}
