using LogicaNegocio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public abstract class Usuario
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public Rol Rol { get; private set; }
        protected Usuario(string email, string password, Rol rol)
        {
            this.Email = email;
            this.Password = password;
            this.Rol = rol;
        }
    }
}
