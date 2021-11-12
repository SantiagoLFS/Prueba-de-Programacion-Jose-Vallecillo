using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos_Control_Ingresos;
using Entidades_Control_Ingreso;
namespace Negocios_Control_Ingresos
{
    public class Negocios_Departamento
    {
        public static DataTable Listar()// llama al metodo listar de la capa datos de la clase metodos varios 
        {
            Metodos_Departamento datos = new Metodos_Departamento();
            return datos.Listar();
        }//fin listar
        public static string Insert_departamento(string nombre_departamento) // llama el metodo insertar de la capa datos de la clase metodos_empleado
        {
            Metodos_Departamento upd = new Metodos_Departamento();
            Entidades_Departamento vari = new Entidades_Departamento();
            vari.Nombre_departamento = nombre_departamento;
            return upd.Insert_departamento(vari);
        }//fin insertar
        public static string Eliminar_departamento(int id) //llama al metodo eliminar de la capa datos de la clase metodos varios 
        {
            Metodos_Departamento dele = new Metodos_Departamento();
            return dele.Eliminar(id);
        }//fin eliminar
        public static string Update_departamento( string nombre_departamento) // llama el metodo actualizar de la capa datos de la clase metodos_empleado
        {
            Metodos_Departamento upd = new Metodos_Departamento();
            Entidades_Departamento vari = new Entidades_Departamento();
            vari.Nombre_departamento = nombre_departamento;
            return upd.Update_departamento(vari);
        }//fin actualizar
        public static DataTable Buscar(string valor)
        {
            Metodos_Departamento busc = new Metodos_Departamento();
            return busc.Buscar(valor);
        }
    }
}
