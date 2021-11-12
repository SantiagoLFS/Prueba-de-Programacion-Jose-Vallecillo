using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades_Control_Ingreso;
namespace Datos_Control_Ingresos
{
   public class Metodos_Departamento
    {
        public string Eliminar(int id) // metodo eliminar dato de una tabla 
        {
            string resul = "";
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = Conexion_CI.InstanciaConexion().OpenBD();
                SqlCommand comando = new SqlCommand("", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_departamento", SqlDbType.Int).Value = id;
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
                comando.Parameters.Add("@nombre_departamento", SqlDbType.VarChar).Value = buscar;
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
        public string Insert_departamento(Entidades_Departamento variables)// se define la capa entidades para poder utilizar las variables almacenada en ellas
        {
            string resul = "";
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = Conexion_CI.InstanciaConexion().OpenBD();
                SqlCommand comando = new SqlCommand("", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_departamento", SqlDbType.Int).Value = variables.Id_departamento;
                comando.Parameters.Add("@nombre_departamento", SqlDbType.VarChar).Value = variables.Nombre_departamento;
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
        public string Update_departamento(Entidades_Departamento variables) //metodo actualizar datos en tabla empleados
        {
            string resul = "";
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = Conexion_CI.InstanciaConexion().OpenBD();
                SqlCommand comando = new SqlCommand("", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_departamento", SqlDbType.Int).Value = variables.Id_departamento;
                comando.Parameters.Add("@nombre_departamento", SqlDbType.VarChar).Value = variables.Nombre_departamento;
                
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
