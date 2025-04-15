using LogicaNegocio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Empleado : Usuario
    {
        public Empleado(string nombre, string apellido, string email, string password, Rol rol)
            : base(nombre, apellido, email, password, rol){}
        void Login(string email, string password)
        {
            // Implementar la lógica de inicio de sesión
            // Por ejemplo, verificar si el correo electrónico y la contraseña son correctos
        }

        public Empleado() : base() { }
        void CerrarSesion() {}
        void AltaEnvio(Envio envio) { }
        void Comentar(string comentario) { }
        Envio DetalleEnvio(int numeroTracking)
        {
            // Implementar la lógica para obtener los detalles del envío
            // Por ejemplo, buscar el envío por el número de seguimiento y devolverlo
            return null;
        }

    }
}
