using System;
using System.Collections.Generic;

namespace SystemRRHH
{
    class Vacaciones
    {

        public static void buscarEmpleadoVac(List<IObjetos> contratolista)
        {
            Console.Clear();

             if (contratolista.Count != 0)
            {
                int conf = 0;

               Console.WriteLine("Digite la cédula del empleado que tendrá vacaciones: ");
                double cedconf = Convert.ToDouble(Console.ReadLine());

                for (int i = 0; i < contratolista.Count; i++)
                {
                    if (contratolista[i].Cedula == cedconf)
                    {
                        Console.Clear();

                       Console.WriteLine($"Este es el empleado?{Environment.NewLine}Nomre: {contratolista[i].Nombre}" +
                            $"{Environment.NewLine}" +
                            $"Cargo: {contratolista[i].Cargo}{Environment.NewLine}" +
                            $"Cedula: {contratolista[i].Cedula}{Environment.NewLine}" +
                            $"{Environment.NewLine}1. Si " +
                            $"{Environment.NewLine}2. No");
                        cedconf = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();


                        if (cedconf == 1)
                        {
                            vacaciones();
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
        private static void vacaciones()
        {
            Console.WriteLine("A continuación digitará la fecha de inicio y luego la fecha final de las vacaciones");
            Console.WriteLine(Environment.NewLine + "Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();

           Console.WriteLine("Fecha de Inicio: " + Environment.NewLine);
            DateTime FechaInicio = Fechas.registrarfechas();
            Console.WriteLine("Fecha Fin: " + Environment.NewLine);
            DateTime FechaFinal = Fechas.registrarfechas();

            TimeSpan FechaTotal = FechaFinal - FechaInicio;

            int diasVacaciones = FechaTotal.Days;

            Console.WriteLine($"El inicio de sus vacaciones será el {FechaInicio} y terminará el {FechaFinal}." +
                $"{Environment.NewLine}Tendrá un total de {diasVacaciones} días de vacaciones.");

            Console.WriteLine(Environment.NewLine + "Presione una tecla para continuar");
            Console.ReadKey();
        }

    }
}
