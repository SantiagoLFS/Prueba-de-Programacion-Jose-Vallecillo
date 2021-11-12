using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades_Control_Ingreso;
using Datos_Control_Ingresos;
namespace Negocios_Control_Ingresos
{
   public class Negocios_Ubicacion
    {
        public static DataTable Listar()// llama al metodo listar de la capa datos de la clase metodos varios 
        {
            Metodos_Ubicacion datos = new Metodos_Ubicacion();
            return datos.Listar();
        }//fin listar
        public static string Insert_ubicacion(string descrip_ubicacion) // llama el metodo insertar de la capa datos de la clase metodos_empleado
        {
            Metodos_Ubicacion upd = new Metodos_Ubicacion();
            Entidades_Ubicacion vari = new Entidades_Ubicacion();
            vari.Descrip_ubicacion = descrip_ubicacion;
            return upd.Insert_ubicacion(vari);
        }//fin insertar
        public static string Eliminar_Ubicacion(int id) //llama al metodo eliminar de la capa datos de la clase metodos varios 
        {
            Metodos_Ubicacion dele = new Metodos_Ubicacion();
            return dele.Eliminar(id);
        }//fin eliminar
        public static string Update_ubicacion(int id_ubicacion, string descrip_ubicacion) // llama el metodo actualizar de la capa datos de la clase metodos_empleado
        {
            Metodos_Ubicacion upd = new Metodos_Ubicacion();
            Entidades_Ubicacion vari = new Entidades_Ubicacion();
            vari.Descrip_ubicacion = descrip_ubicacion;
            
            return upd.Update_ubicacion(vari);
        }//fin actualizar
        public static DataTable Buscar(string valor)
        {
            Metodos_Ubicacion busc = new Metodos_Ubicacion();
            return busc.Buscar(valor);
        }
    }
}
