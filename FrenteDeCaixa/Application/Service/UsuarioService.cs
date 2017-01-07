using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Context;
using FrenteDeCaixa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service
{
    class UsuarioService : IUsuarioService
    {
        private EntidadesContext Banco { get; set; }

        public UsuarioService()
        {
            Banco = new EntidadesContext();
        }

        public void Salvar(UsuarioDomain usuario)
        {
            Banco.Usuarios.Add(usuario);
            Banco.SaveChanges();
        }

        public void Alterar(UsuarioDomain usuario)
        {
            UsuarioDomain usuarioAux = Banco.Usuarios.Where(x => x.Id == usuario.Id).First();
            usuarioAux.Login = usuario.Login;
            usuarioAux.Senha = usuario.Senha;
            usuarioAux.Nome  = usuario.Nome;
            usuarioAux.PerfilId = usuario.PerfilId;
            usuarioAux.Perfil   = usuario.Perfil;
            Banco.SaveChanges();
        }

        public void Excluir(UsuarioDomain usuario)
        {
            Banco.Set<UsuarioDomain>().Remove(usuario);
            Banco.SaveChanges();
        }

        public List<UsuarioDomain> Listar()
        {
            return (from c in Banco.Usuarios select c).ToList();
        }
    }
}
