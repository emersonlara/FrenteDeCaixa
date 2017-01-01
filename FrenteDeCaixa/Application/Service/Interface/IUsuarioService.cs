using FrenteDeCaixa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Application.Service.Interface
{
    interface IUsuarioService
    {
        void Salvar(Usuario usuario);
        void Alterar(Usuario usuario);
        void Excluir(Usuario usuario);
        List<Usuario> Listar();
    }
}
