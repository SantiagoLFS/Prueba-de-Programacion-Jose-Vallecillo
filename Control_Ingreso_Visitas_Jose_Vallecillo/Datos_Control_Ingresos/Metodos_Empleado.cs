using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades_Control_Ingreso;
namespace Datos_Control_Ingresos
{
    public class Metodos_Empleado
    {
        public string Insert_empleado(Entidades_Empleado variables)// se define la capa entidades para poder utilizar las variables almacenada en ellas
        {
            string resul = "";
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = Conexion_CI.InstanciaConexion().OpenBD();
                SqlCommand comando = new SqlCommand("sp_inser_empleado", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_empleado", SqlDbType.Int).Value = variables.Id_empleado;
                comando.Parameters.Add("@nombre_empleado", SqlDbType.VarChar).Value = variables.Nombre_empleado ;
                comando.Parameters.Add("@apellido_empleado", SqlDbType.VarChar).Value = variables.Apellido_empleado ;
                cn.Open();
                resul = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE INGRESO EL REGISTRO";
            }
            catch (Exception ex)
            {
                resul =  ex.Message;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }
            return resul;
        }
        public string Update_empleado(Entidades_Empleado variables) //metodo actualizar datos en tabla empleados
        {
            string resul = "";
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = Conexion_CI.InstanciaConexion().OpenBD();
                SqlCommand comando = new SqlCommand("", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_empleado", SqlDbType.Int).Value = variables.Id_empleado;
                comando.Parameters.Add("@nombre_empleado", SqlDbType.VarChar).Value = variables.Nombre_empleado;
                comando.Parameters.Add("@apellido_empleado", SqlDbType.VarChar).Value = variables.Apellido_empleado;
                cn.Open();
                resul = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE ACTUALIZO EL REGISTRO";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }
            return resul;
        }
    }
}
