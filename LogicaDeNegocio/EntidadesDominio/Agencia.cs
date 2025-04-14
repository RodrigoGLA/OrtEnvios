using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Agencia
    {
        public int Id { get; private set; }
        public string DireccionPostal { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<Envio> Envios { get; set; }

        public Agencia (string direccionPostal, string latitud, string longitud)
        {
            this.DireccionPostal = direccionPostal;
            this.Latitud = latitud;
            this.Longitud = longitud;
            this.Usuarios = new List<Usuario>();
            this.Envios = new List<Envio>();
        }




    }
}
