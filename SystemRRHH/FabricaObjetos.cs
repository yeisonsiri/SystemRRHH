using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRRHH
{
    class FabricaObjetos
    {
       public static ICloneable fabricaClone(int i)
        {
            if (i == 1)
            {
                return new EmpleadoAtributos();
            }
            else
            {
                return null;
            }
        }
    }
}
