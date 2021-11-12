using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_Control_Ingresos;
using Entidades_Control_Ingreso;
namespace Negocios_Control_Ingresos
{
    public class Negocios_Empleado
    {
        public static DataTable Listar()// llama al metodo listar de la capa datos de la clase metodos varios 
        {
            Metodo_Varios datos = new Metodo_Varios();
            return datos.Listar();
        }//fin listar
        public static string  Insert_empleado(int id_empleado, string nombre_empleado, string apellido_empleado) // llama el metodo insertar de la capa datos de la clase metodos_empleado
        {
            Metodos_Empleado upd= new Metodos_Empleado();
            Entidades_Empleado vari = new Entidades_Empleado();
            vari.Id_empleado = id_empleado;
            vari.Nombre_empleado = nombre_empleado;
            vari.Apellido_empleado = apellido_empleado;
            return upd.Insert_empleado(vari);
        }//fin insertar
        public static string Eliminar_empleado(int id) //llama al metodo eliminar de la capa datos de la clase metodos varios 
        {
            Metodo_Varios dele = new Metodo_Varios();
            return dele.Eliminar(id);
        }//fin eliminar
        public static string Update_empleado(int id_empleado, string nombre_empleado, string apellido_empleado) // llama el metodo actualizar de la capa datos de la clase metodos_empleado
        {
            Metodos_Empleado upd = new Metodos_Empleado();
            Entidades_Empleado vari = new Entidades_Empleado();
            vari.Id_empleado = id_empleado;
            vari.Nombre_empleado = nombre_empleado;
            vari.Apellido_empleado = apellido_empleado;
            return upd.Update_empleado(vari);
        }//fin actualizar
        public static DataTable Buscar(string valor)
        {
            Metodo_Varios busc = new Metodo_Varios();
            return busc.Buscar(valor);
        }
    }
}
