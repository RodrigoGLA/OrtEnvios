using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Urgente : Envio
    {
        string DireccionPostal { get; set; }
        string Valor { get; set; }
        DateTime FechaSalida { get; set; }
        DateTime FechaEntrega { get; set; }
        Boolean EnvioRapido { get; set; }
        public Urgente(int idEnvio, int numeroTracking, string pesoPaquete, string estado, string direccionPostal, string valor, DateTime fechaSalida, DateTime fechaEntrega, Boolean envioRapido)
            : base(idEnvio, numeroTracking, pesoPaquete, estado)
        {
            this.DireccionPostal = direccionPostal;
            this.Valor = valor;
            this.FechaSalida = fechaSalida;
            this.FechaEntrega = fechaEntrega;
            this.EnvioRapido = envioRapido;
        }

        Boolean CalculoEnvioExitoso(DateTime fechaSalida, DateTime FechaEntrega)
        {
            // Implementar la lógica para calcular si el envío fue exitoso
            // Por ejemplo, verificar si la fecha de entrega es posterior a la fecha de salida
            return true;
        }
    }
    }

