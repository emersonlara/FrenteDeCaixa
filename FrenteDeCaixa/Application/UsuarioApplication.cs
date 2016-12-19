﻿using FrenteDeCaixa.Context;
using FrenteDeCaixa.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application
{
    class UsuarioApplication
    {
        private EntidadesContext Banco { get; set; }

        public UsuarioApplication()
        {
            Banco = new EntidadesContext();
        }

        public void Salvar(Usuario usuario)
        {
            Banco.Usuarios.Add(usuario);
            Banco.SaveChanges();
        }

        public void Alterar(Usuario usuario)
        {
            Usuario usuarioAux = Banco.Usuarios.Where(x => x.Id == usuario.Id).First();
            usuarioAux.Login = usuario.Login;
            usuarioAux.Senha = usuario.Senha;
            usuarioAux.Nome  = usuario.Nome;
            usuarioAux.Tipo  = usuario.Tipo;
            Banco.SaveChanges();
        }

        public void Excluir(Usuario usuario)
        {
            Banco.Set<Usuario>().Remove(usuario);
            Banco.SaveChanges();
        }

        public IEnumerable<Usuario> Listar()
        {
            return from c in Banco.Usuarios select c;
        }
    }
}