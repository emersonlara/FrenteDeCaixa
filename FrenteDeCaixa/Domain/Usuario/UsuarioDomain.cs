using FrenteDeCaixa.Domain.PerfilDeUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Domain.Usuario
{
    public class UsuarioDomain : IUsuario
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public Guid? PerfilId { get; set; }
        public PerfilDeUsuarioDomain Perfil { get; set; }

        public UsuarioDomain(Guid Id, string Login, string Senha, string Nome, Guid? PerfilId, PerfilDeUsuarioDomain Perfil)
        {
            this.Id = Id;
            this.Login = Login;
            this.Senha = Senha;
            this.Nome = Nome;
            this.PerfilId = PerfilId;
            this.Perfil = Perfil;
        }
    }
}
