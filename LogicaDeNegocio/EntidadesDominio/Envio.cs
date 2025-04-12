using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public abstract class Envio(int idEnvio, int numeroTracking, string pesoPaquete, string estado)
    {
        readonly int idEnvio = idEnvio;
        readonly int numeroTracking = numeroTracking;
        string pesoPaquete = pesoPaquete;
        string estado = estado;
    }
}
