using FrenteDeCaixa.Application.Service.Interface;
using FrenteDeCaixa.Domain.Usuario;
using System.Collections.Generic;
using System.Linq;
using FrenteDeCaixa.Infrastructure.Context;

namespace FrenteDeCaixa.Application.Service
{
    class UsuarioService : IUsuarioService
    {
        private EntidadesContext Banco { get; }

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
            var usuarioAux = Banco.Usuarios.First(x => x.Id == usuario.Id);
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
