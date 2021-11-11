using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos_Control_Ingresos
{
    class Conexion_CI
    {
        private readonly string BD; // almacena nombre de la base de datos
        private readonly string SD; // almacena nombre del servidor 
        private static Conexion_CI cnn = null;
        private Conexion_CI()
        {
            this.BD = "Control_Ingresos_SM";
            this.SD = "DESKTOP-TOOKI5B";
        }
        public SqlConnection OpenBD()//  metodo de conexion
        {
            SqlConnection conexionFS = new SqlConnection();
            try
            {
                conexionFS.ConnectionString = "Data Source=" + this.SD + "; Initial Catalog=" + this.BD + "; Integrated Security = SSPI";
            }
            catch (Exception excep)
            {
                conexionFS = null;
                throw excep;
            }
            return conexionFS;
        }
        public static Conexion_CI InstanciaConexion() // metodo para crear instancia de la conexion
        {
            if (cnn == null)
            {
                cnn = new Conexion_CI();
            }
            return cnn;
        }
    }
}
