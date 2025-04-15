using LogicaNegocio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Funcionario: Empleado
    {
        public Funcionario(string nombre, string apellido, string email, string password, Rol rol)
            : base(nombre, apellido, email, password, rol) { }
        public Funcionario() : base() { }
    }
}
