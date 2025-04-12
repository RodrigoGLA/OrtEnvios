using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Agencia
    {
        public readonly int IdAgencia;
        public string DireccionPostal;
        public string Latitud;
        public string Longitud;
        public List<Usuario> Usuarios;
        public List<Envio> Envios;

        public Agencia (string direccionPostal, string latitud, string longitud)
        {
            this.IdAgencia++;
            this.DireccionPostal = direccionPostal;
            this.Latitud = latitud;
            this.Longitud = longitud;
            this.Usuarios = new List<Usuario>();
            this.Envios = new List<Envio>();
        }




    }
}
