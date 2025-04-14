using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public abstract class Envio
    {
        public int Id { get; private set; }
        public int NumeroTracking { get; private set; }
        public string PesoPaquete { get; private set; }
        public string Estado { get; private set; }

        public Envio(int numeroTracking, string pesoPaquete, string estado)
        {
            NumeroTracking = numeroTracking;
            PesoPaquete = pesoPaquete;
            Estado = estado;
        }
    }
}