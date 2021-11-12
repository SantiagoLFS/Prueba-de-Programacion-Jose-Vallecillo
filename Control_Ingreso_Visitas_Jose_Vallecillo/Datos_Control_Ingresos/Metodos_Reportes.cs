using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos_Control_Ingresos
{
    public class Metodos_Reportes
    {
        public DataTable Buscar(DateTime fecha_final, DateTime fecha_inicial) //metodo para buscar en las tablas de sql contiene una variable para poder sustituirla con la de los procesos alamacenados
        {
            SqlDataReader resul;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = Conexion_CI.InstanciaConexion().OpenBD();
                SqlCommand comando = new SqlCommand("visualizar_por_depar", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = fecha_final;
                comando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = fecha_inicial;
                cn.Open();
                resul = comando.ExecuteReader();
                tabla.Load(resul);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }
        }//fin del metodo buscar
    }
}
