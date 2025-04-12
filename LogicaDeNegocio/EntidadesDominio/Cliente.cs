using LogicaNegocio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Cliente : Usuario
    {
        public List<Urgente> EnviosUrgentes { get; }
        public Cliente(string email, string password, Rol rol)
            : base(email, password, rol)
        {
            EnviosUrgentes = new List<Urgente>();
        }

    }
}
