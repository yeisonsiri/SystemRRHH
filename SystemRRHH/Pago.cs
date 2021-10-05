using System;
using System.Collections.Generic;

namespace SystemRRHH
{
    class Pago
    {

        public static void pagar(List<IObjetos> contratolista)
        {
            Console.Clear();
            if (contratolista.Count != 0)
            {

                Console.WriteLine("Esperar hasta que se confirme el éxito de crear el archivo Excell");
                Console.WriteLine("Presione una tecla para Continuar!");
                Console.ReadKey();
                Console.Clear();

                for (int i = 0; i < contratolista.Count; i++)
                {
                    double AFP = contratolista[i].Salario * 0.0287;
                    double ARS = contratolista[i].Salario * 0.0301;
                    double SalarioNeto = contratolista[i].Salario - AFP - ARS + contratolista[i].Ingresos - contratolista[i].Descuentos;
                    
                    ImprimirNomina.imprimirnomina(contratolista, AFP, ARS, SalarioNeto, i);

                    ExcellNomina.nominaexcell(contratolista, AFP, ARS, SalarioNeto, i);
                }

                Console.WriteLine("Presione una tecla para Continuar!");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Empleados impresos en Excell satisfactoriamente!!!");
                Console.WriteLine("Carpeta: (Proyecto//bin//Debug//net5.0)");
                Console.WriteLine("Presione una tecla para Continuar!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Aún no existen empleados en el sistema");
                Console.WriteLine("Presione una tecla para Continuar!");
                Console.ReadKey();
            }
        }
    }


    class ImprimirNomina
    {

       public static void imprimirnomina(List<IObjetos> contratolista, double AFP, double ARS, double SalarioNeto, int i)
        {
            
            Console.WriteLine($"Empleado #{i + 1}" + Environment.NewLine + Environment.NewLine +
                    $"Nombre: {contratolista[i].Nombre}" + Environment.NewLine +
                    $"Departamento: {contratolista[i].Departamento}" + Environment.NewLine +
                    $"Salario: {contratolista[i].Salario}" + Environment.NewLine +
                    $"Otros Ingresos: {contratolista[i].Ingresos}" + Environment.NewLine +
                    $"AFP: {AFP}" + Environment.NewLine +
                    $"ARS: {ARS}" + Environment.NewLine +
                    $"Otros Descuentos: {contratolista[i].Descuentos}" + Environment.NewLine +
                    $"Sueldo Neto: {SalarioNeto}" + Environment.NewLine);

            if (i + 1 != contratolista.Count)
            {
                Console.WriteLine(Environment.NewLine + Environment.NewLine);
            }
        }

    }
}
