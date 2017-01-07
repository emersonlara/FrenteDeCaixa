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
        void Salvar(UsuarioDomain usuario);
        void Alterar(UsuarioDomain usuario);
        void Excluir(UsuarioDomain usuario);
        List<UsuarioDomain> Listar();
    }
}
