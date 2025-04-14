using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Comun : Envio
    {
        public string Agencia { get; set; }
        public Comun(int numeroTracking, string pesoPaquete, string estado, string agencia) : base(numeroTracking, pesoPaquete, estado)
        {
            Agencia = agencia;
        }
    }
    
    }

