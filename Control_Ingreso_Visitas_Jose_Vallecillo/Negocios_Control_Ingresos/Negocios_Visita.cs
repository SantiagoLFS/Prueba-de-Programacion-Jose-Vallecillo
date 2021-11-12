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
    public class Negocios_Visita
    {
        public static DataTable Listar()// llama al metodo listar de la capa datos de la clase metodos varios 
        {
            Metodos_Visita datos = new Metodos_Visita();
            return datos.Listar();
        }//fin listar
        public static string Insert_visita(string identidad_visita, string nombre_visita, string apellido_visita) // llama el metodo insertar de la capa datos de la clase metodos_empleado
        {
            Metodos_Visita upd = new Metodos_Visita();
            Entidades_Visita vari = new Entidades_Visita();
            vari.Identidad_visitante = identidad_visita;
            vari.Nombre_visita = nombre_visita;
            vari.Apellido_visita = apellido_visita;
            return upd.Insert_visita(vari);
        }//fin insertar
        public static string Eliminar_vista(int id) //llama al metodo eliminar de la capa datos de la clase metodos varios 
        {
            Metodos_Visita dele = new Metodos_Visita();
            return dele.Eliminar(id);
        }//fin eliminar
        public static string Update_visita(string identidad_visita, string nombre_visita, string apellido_visita) // llama el metodo actualizar de la capa datos de la clase metodos_empleado
        {
            Metodos_Visita upd = new Metodos_Visita();
            Entidades_Visita vari = new Entidades_Visita();
            vari.Identidad_visitante = identidad_visita;
            vari.Nombre_visita = nombre_visita;
            vari.Apellido_visita = apellido_visita;
            return upd.Update_visita(vari);
        }//fin actualizar
        public static DataTable Buscar(string valor)
        {
            Metodos_Visita busc = new Metodos_Visita();
            return busc.Buscar(valor);
        }
    }
}
