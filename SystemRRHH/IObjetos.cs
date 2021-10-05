using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRRHH
{
   interface IObjetos
    {
        public double Cedula { get; set; }
        public string Nombre { get; set; }
        public int Departamento { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public double Ingresos { get; set; }
        public double Descuentos { get; set; }
    }
}
