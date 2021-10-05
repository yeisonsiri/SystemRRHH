using System;
using System.Collections.Generic;

namespace SystemRRHH
{
    class Program
    {
        public static int conf;
        static void Main(string[] args)
        {
            FuncionesClienteFachada fcf = new FuncionesClienteFachada();

            do
            {
                do
                {
                    Console.Clear();
                Console.WriteLine("Bienvenido al Sistema RRHH, sección de administración de empleados, eija la opción que desea " +
                "utilizar a continuación: " + Environment.NewLine + 
                "1. Contratar nuevo empleado" + Environment.NewLine +
                "2. Desvincular Empleados" + Environment.NewLine +
                "3. Pagar a empleados e Imprimir Nómina" + Environment.NewLine +
                "4. Salir del programa");
                    conf = Convert.ToInt32(Console.ReadLine());
                } while (conf > 4 || conf < 1);

                switch (conf)
                {
                    case 1:
                       fcf.Contratacion();
                        break;
                    case 2:
                        fcf.DesvinculacionFuncion();
                        break;
                    case 3:
                        fcf.PagoFuncion();
                        break;
                }


            } while (conf != 4);

        }
    }
}
