using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRRHH
{
    class FuncionesClienteFachada
    {
private static ICloneable clone = FabricaObjetos.fabricaClone(1);

        private static List<IObjetos> contratolista = new List<IObjetos>();

        public void Contratacion()
        {
           contratolista.Add((IObjetos)ContratacionCrear.contratar((IObjetos)clone.Clone()));
        }
        public void DesvinculacionFuncion()
        {
            Desvinculacion.desvincular(contratolista);
        }
        public void PagoFuncion()
        {
            Pago.pagar(contratolista);
        }

    }
}
