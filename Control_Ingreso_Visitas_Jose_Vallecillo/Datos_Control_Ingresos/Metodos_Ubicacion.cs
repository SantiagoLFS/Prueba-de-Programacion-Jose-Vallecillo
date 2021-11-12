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
    public class Metodos_Ubicacion
    {
        public string Insert_ubicacion(Entidades_Ubicacion variables)// se define la capa entidades para poder utilizar las variables almacenada en ellas
        {
            string resul = "";
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = Conexion_CI.InstanciaConexion().OpenBD();
                SqlCommand comando = new SqlCommand("sp_inser_ubicacion", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@descrip_ubicacion", SqlDbType.VarChar).Value = variables.Descrip_ubicacion;
                cn.Open();
                resul = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE INGRESO EL REGISTRO";
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
        public string Update_ubicacion(Entidades_Ubicacion variables) //metodo actualizar datos
        {
            string resul = "";
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = Conexion_CI.InstanciaConexion().OpenBD();
                SqlCommand comando = new SqlCommand("", cn);
                comando.CommandType = CommandType.StoredProcedure;
                
                comando.Parameters.Add("@descrip_ubicacion", SqlDbType.VarChar).Value = variables.Descrip_ubicacion;

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
        public string Eliminar(int id) // metodo eliminar dato de una tabla 
        {
            string resul = "";
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = Conexion_CI.InstanciaConexion().OpenBD();
                SqlCommand comando = new SqlCommand("", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_ubicacion", SqlDbType.Int).Value = id;
                cn.Open();
                resul = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE ELIMINAR EL REGISTRO";
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
        }//fin del metodo eliminar
        public DataTable Listar()//metodo listar para mostrar los procedimientos almacenados select
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
        }//fin del metodo listar
        public DataTable Buscar(string buscar) //metodo para buscar en las tablas de sql contiene una variable para poder sustituirla con la de los procesos alamacenados
        {
            SqlDataReader resul;
            DataTable tabla = new DataTable();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = Conexion_CI.InstanciaConexion().OpenBD();
                SqlCommand comando = new SqlCommand("", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("", SqlDbType.VarChar).Value = buscar;
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
