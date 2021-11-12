using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos_Control_Ingresos;
namespace Negocios_Control_Ingresos
{
    public class Negocios_Reporte
    {
        public static DataTable Buscar(DateTime fecha_final, DateTime fecha_inicial)
        {
             Metodos_Reportes busc = new Metodos_Reportes();
            return busc.Buscar(fecha_final, fecha_inicial);
        }
    }
}
