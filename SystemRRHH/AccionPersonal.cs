using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRRHH
{
    class AccionPersonal
    {

        public static void accionpersonal(List<IObjetos> contratolista)
        {
            Console.Clear();

            if (contratolista.Count != 0)
            {
                Console.WriteLine("Indique la opción a realizar" + Environment.NewLine +
                "1. Dar incentivo a un empleaado" + Environment.NewLine +
                "2. Descontar a un empleado");
                int conf = Convert.ToInt32(Console.ReadLine());

                if (conf <= 2 && conf >= 1)
                {
                    Console.Clear();

                    Console.WriteLine("Digite el número del empleado con el que desea trabajar" + Environment.NewLine);
                    for (int i = 0; i < contratolista.Count; i++)
                    {
                        Console.WriteLine((i + 1) + $". {contratolista[i].Nombre}");
                    }
                    int emp = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Clear();

                    switch (conf)
                    {
                        case 1:
                           darIngreso(contratolista, emp);
                            break;

                        case 2:
                            descontar(contratolista, emp);
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Aún no existen empleados en el sistema");
                Console.WriteLine("Presione una tecla para Continuar!");
                Console.ReadKey();
            }
            
            
        }
        private static void darIngreso(List<IObjetos> contratolista, int emp)
        {
            Console.WriteLine("Digite el monto a añadir al empleado");
            double monto = Convert.ToDouble(Console.ReadLine());
            contratolista[emp].Ingresos += monto; 
            Console.WriteLine("Escriba el concepto por el que se da el incentivo");
            string concept = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"El empleado: {contratolista[emp].Nombre} recibirá un incentivo de {monto}" 
                + Environment.NewLine + $"Concepto: {concept}"); 
            Console.WriteLine(Environment.NewLine + "Presione una tecla para continuar");
            Console.ReadKey();
        }


       private static void descontar(List<IObjetos> contratolista, int emp)
        {
            Console.WriteLine("Digite el monto a descontar en el empleado");
            double monto = Convert.ToDouble(Console.ReadLine());
            contratolista[emp].Descuentos += monto; 
            Console.WriteLine("Escriba el concepto por el que se hace el descuento");
            string concept = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"El empleado: {contratolista[emp].Nombre} recibirá un descuento de {monto}"
                + Environment.NewLine + $"Concepto: {concept}");
            Console.WriteLine(Environment.NewLine + "Presione una tecla para continuar");
            Console.ReadKey();
        }

    }
}
