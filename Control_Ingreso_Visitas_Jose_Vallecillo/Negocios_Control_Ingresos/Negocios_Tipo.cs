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
    public class Negocios_Tipo
    {
        public static DataTable Listar()// llama al metodo listar de la capa datos de la clase metodos varios 
        {
            Metodos_Tipo datos = new Metodos_Tipo();
            return datos.Listar();
        }//fin listar
        public static string Insert_tipo(int id_tipo, string descrip_tipo) // llama el metodo insertar de la capa datos de la clase metodos_empleado
        {
            Metodos_Tipo upd = new Metodos_Tipo();
            Entidades_Tipo vari = new Entidades_Tipo();
            vari.Id_tipo = id_tipo;
            vari.Descrip_tipo = descrip_tipo;
            return upd.Insert_tipo(vari);
        }//fin insertar
        public static string Eliminar(int id) //llama al metodo eliminar de la capa datos de la clase metodos varios 
        {
            Metodos_Ubicacion dele = new Metodos_Ubicacion();
            return dele.Eliminar(id);
        }//fin eliminar
        public static string Update_tipo(int id_tipo, string descrip_tipo) // llama el metodo actualizar de la capa datos de la clase metodos_empleado
        {
            Metodos_Tipo upd = new Metodos_Tipo();
            Entidades_Tipo vari = new Entidades_Tipo();
            vari.Id_tipo = id_tipo;
            vari.Descrip_tipo = descrip_tipo;

            return upd.Update_tipo(vari);
        }//fin actualizar
        public static DataTable Buscar(string valor)
        {
            Metodos_Tipo busc = new Metodos_Tipo();
            return busc.Buscar(valor);
        }
    }
}
