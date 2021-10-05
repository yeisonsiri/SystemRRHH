using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRRHH
{
    class Desvinculacion
    {

        public static void desvincular(List<IObjetos> contratolista)
        {
            Console.Clear();

            int conf;
            int conf2;


            if (contratolista.Count != 0)
            {

                do
                {
                    Console.WriteLine("Digite el número del empleado que desea desvincular" + Environment.NewLine);
                    for (int i = 0; i < contratolista.Count; i++)
                    {
                        Console.WriteLine((i + 1) + $". {contratolista[i].Nombre}");
                    }
                    conf = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Clear();
                } while (conf > contratolista.Count - 1 || conf < 0);

                Console.WriteLine("Seguro que desea desvincular el empleado?" + Environment.NewLine +
                    "1. Si" + Environment.NewLine +
                    "2. No");
                conf2 = Convert.ToInt32(Console.ReadLine());

                if (conf2 == 1)
                {
                    contratolista.RemoveAt(conf);
                    Console.WriteLine("Empleado Desvinculado Exitosamente!");
                    Console.WriteLine("Presione una tecla para Continuar!");
                    Console.ReadKey();
                    Console.Clear();
                }

                
            }
            else
            {
                Console.WriteLine("Aún no existen empleados en el sistema");
                Console.WriteLine("Presione una tecla para Continuar!");
                Console.ReadKey();
            }
            

        }

    }
}
