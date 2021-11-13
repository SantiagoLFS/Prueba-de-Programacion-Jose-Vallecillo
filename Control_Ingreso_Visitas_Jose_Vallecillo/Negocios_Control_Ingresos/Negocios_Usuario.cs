using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos_Control_Ingresos;
using Entidades_Control_Ingreso;
namespace Negocios_Control_Ingresos
{
    public class Negocios_Usuario
    {
        public static DataTable Listar_usuario()// llama al metodo listar de la capa datos de la clase metodos varios 
        {
            Metodos_Usuario datos = new Metodos_Usuario();
            return datos.Listar_usuario();
        }//fin listar
        public static string Insert_usurio(string nombre_usuario, string contrasena_usuario, int id_empleado, int id_tipo) // llama el metodo insertar de la capa datos de la clase metodos_empleado
        {
            Metodos_Usuario upd = new Metodos_Usuario();
            Entidades_Usuario vari = new Entidades_Usuario();
            vari.Nombre_usuario = nombre_usuario;
            vari.Contrasena_usuario = contrasena_usuario;
            vari.Id_empleado = id_empleado;
            vari.Id_tipo = id_tipo;
            return upd.Insert_usuario(vari);
        }//fin insertar
        public static string Eliminar_usuario(int id) //llama al metodo eliminar de la capa datos de la clase metodos varios 
        {
            Metodos_Usuario dele = new Metodos_Usuario();
            return dele.Eliminar_usuario(id);
        }//fin eliminar
        public static string Update_usuario(string nombre_usuario, string contrasena_usuario, int id_empleado, int id_tipo) // llama el metodo actualizar de la capa datos de la clase metodos_empleado
        {
            Metodos_Usuario upd = new Metodos_Usuario();
            Entidades_Usuario vari = new Entidades_Usuario();
            vari.Nombre_usuario = nombre_usuario;
            vari.Contrasena_usuario = contrasena_usuario;
            vari.Id_empleado = id_empleado;
            vari.Id_tipo = id_tipo;
            return upd.Update_usuario(vari);
        }//fin actualizar
        public static DataTable Buscar_usuario(string valor)
        {
            Metodos_Usuario busc = new Metodos_Usuario();
            return busc.Buscar_usuario(valor);
        }
    }
}
