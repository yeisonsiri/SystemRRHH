using System;
using System.Collections.Generic;

namespace SystemRRHH
{
    class Permiso
    {

        public static void darPermiso(List<IObjetos> contratolista)
        {
            Console.Clear();

            if (contratolista.Count != 0)
            {
                int conf = 0;

                Console.WriteLine("Digite la cédula del empleado al que se le otorgará el permiso: ");
                double perconf = Convert.ToDouble(Console.ReadLine());

                for (int i = 0; i < contratolista.Count; i++)
                {
                    if (contratolista[i].Cedula == perconf)
                    {
                        Console.Clear();

                       Console.WriteLine($"Este es el empleado?{Environment.NewLine}Nomre: {contratolista[i].Nombre}" +
                            $"{Environment.NewLine}" +
                            $"Cargo: {contratolista[i].Cargo}{Environment.NewLine}" +
                            $"Cedula: {contratolista[i].Cedula}{Environment.NewLine}" +
                            $"{Environment.NewLine}1. Si " +
                            $"{Environment.NewLine}2. No");
                        perconf = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();

                       if (perconf == 1)
                        {
                            permiso();
                            conf = 1;
                        }
                    }
                }
                if (conf == 0)
                {
                    Console.WriteLine("Confirme el número de cédula digitado y vuelva a intentar");
                    Console.WriteLine(Environment.NewLine + "Presione una tecla para continuar");
                    Console.ReadKey();
                }


            }
            else
            {
                Console.WriteLine("Aún no existen empleados en el sistema");
                Console.WriteLine("Presione una tecla para Continuar!");
                Console.ReadKey();

            }

        }


        private static void permiso()
        {
            Console.WriteLine("A continuación digitará la fecha en la que el empleado se ausentará");
            Console.WriteLine(Environment.NewLine + "Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Fecha en la que se usará el permiso: " + Environment.NewLine);
            DateTime Fecha = Fechas.registrarfechas();
            Console.WriteLine($"El permiso será concedido para ser usado el día {Fecha}");
            Console.WriteLine(Environment.NewLine + "Presione una tecla para continuar");
            Console.ReadKey();
        }

    }
}
