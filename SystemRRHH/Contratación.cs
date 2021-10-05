using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRRHH
{
     class EmpleadoAtributos : ICloneable, IObjetos
    {
        public double Cedula { get; set; }
        public string Nombre { get; set; }
        public int Departamento { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public double Ingresos { get; set; }
        public double Descuentos { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

    }

    class ContratacionCrear
    {
        
        public static object contratar(IObjetos cr)
        {
            Console.Clear();

            Console.WriteLine("Proceso de Contratación de un empleado:" + Environment.NewLine + 
                "Digite su Número de Cédula: ");
            cr.Cedula = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escriba su Nombre");
            cr.Nombre = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite su número de Departamento");
            cr.Departamento = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escriba su Cargo");
            cr.Cargo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite su Salario");
            cr.Salario = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Empleado Registrado Exitosamente!");
            Console.WriteLine("Presione una tecla para Continuar!");
            Console.ReadKey();
            Console.Clear();

            return cr;
        }


    }
}
