using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRRHH
{
    class Fechas
    {
       public static DateTime registrarfechas()
        {
            int Dia;
            int Mes;
            int Year;
            int confFecha = 1;
            string convertir;

            do
            {
               if (confFecha == 0)
                {
                    Console.WriteLine("Escribir la fecha nuevamente, error cometido en la fecha!" + Environment.NewLine);
                }

                confFecha = 0;


               Console.WriteLine("Digite el día (Escribir el número)");
                Dia = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Digite el mes (Escribir el número)");
                Mes = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Digite el año (Escribir el número)");
                Year = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


            } while ((Dia < 1 || Dia > 31) || (Mes < 1 || Mes > 12));


            convertir = $"{Convert.ToString(Dia)}/{Convert.ToString(Mes)}/{Convert.ToString(Year)}";


           DateTime Fecha = DateTime.ParseExact(convertir, "d/M/yyyy", null);

            Console.Clear();

            return Fecha;
        }

    }
}
