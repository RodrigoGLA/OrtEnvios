using System;

namespace LogicaNegocio.EntidadesDominio
{
    public class Urgente : Envio
    {
        public string DireccionPostal { get; set; }
        public string Valor { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool EnvioRapido { get; set; }

        public Urgente(int numeroTracking, string pesoPaquete, string estado, string direccionPostal, string valor, DateTime fechaSalida, DateTime fechaEntrega, bool envioRapido)
            : base(numeroTracking, pesoPaquete, estado)
        {
            DireccionPostal = direccionPostal;
            Valor = valor;
            FechaSalida = fechaSalida;
            FechaEntrega = fechaEntrega;
            EnvioRapido = envioRapido;
        }

        public bool CalculoEnvioExitoso(DateTime fechaSalida, DateTime fechaEntrega)
        {
            // Implementar la lógica para calcular si el envío fue exitoso
            return fechaEntrega > fechaSalida;
        }
    }
}

