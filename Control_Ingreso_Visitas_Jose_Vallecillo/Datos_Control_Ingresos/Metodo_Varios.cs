using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos_Control_Ingresos
{
    class Metodo_Varios
    {
        public DataTable Listar()
        {
            SqlDataReader resul;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = Conexion_CI.InstanciaConexion().OpenBD();
                SqlCommand comando = new SqlCommand("", cn);
                comando.CommandType = CommandType.StoredProcedure;
                cn.Open();
                resul = comando.ExecuteReader();
                tabla.Load(resul);
                return tabla;
            }
            catch(Exception ex) {
                throw ex;
            }
            finally
            {
                if(cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
               
            }
        }
    }
}
