using LogicaNegocio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Administrador: Empleado
    {
        public Administrador(string email, string password, Rol rol)
            : base(email, password, rol) { }

        private void AltaEmpleado(string email, string password, Rol rol) { }
        private void BajaEmpleado(Empleado empleado) { }
        private void EditarEmpleado(Empleado empleado) { }

    }
}
