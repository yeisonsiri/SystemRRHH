using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRRHH
{
    class ExcellNomina
    {

        public static string pathFile = AppDomain.CurrentDomain.BaseDirectory + "NominaEmpleados.xlsx";

        public static SLDocument oSLDocument = new SLDocument();

        public static System.Data.DataTable dt = new System.Data.DataTable();

            public static void nominaexcell(List<IObjetos> contratolista, double AFP, double ARS, double SalarioNeto, int i)
        {

            if (i == 0)
            {
                formatoDocumento(oSLDocument);
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Depto.", typeof(int));
                dt.Columns.Add("Salario", typeof(double));
                dt.Columns.Add("Otros Ingresos", typeof(double));
                dt.Columns.Add("AFP", typeof(double));
                dt.Columns.Add("ARS", typeof(double));
                dt.Columns.Add("Otros descuentos", typeof(double));
                dt.Columns.Add("Sueldo neto", typeof(double));
                
            }


            dt.Rows.Add(contratolista[i].Nombre, contratolista[i].Departamento, contratolista[i].Salario, 
                contratolista[i].Ingresos, AFP, ARS, contratolista[i].Descuentos, SalarioNeto);

            if (i + 1 == contratolista.Count)
            {
                oSLDocument.ImportDataTable(1, 1, dt, true);
                oSLDocument.SaveAs(pathFile);
                oSLDocument = new SLDocument();
                dt = new System.Data.DataTable();
            }
        }
            
        private static void formatoDocumento(SLDocument oSLDocument)
        {

            oSLDocument.SetColumnWidth(1, 40);
            oSLDocument.SetColumnWidth(3, 20);
            oSLDocument.SetColumnWidth(4, 20);
            oSLDocument.SetColumnWidth(5, 20);
            oSLDocument.SetColumnWidth(6, 20);
            oSLDocument.SetColumnWidth(7, 20);
            oSLDocument.SetColumnWidth(8, 20);
        }
    }
}
