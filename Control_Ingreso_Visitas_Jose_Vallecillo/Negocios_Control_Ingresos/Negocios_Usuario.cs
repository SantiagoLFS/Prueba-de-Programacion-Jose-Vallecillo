using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos_Control_Ingresos;
namespace Negocios_Control_Ingresos
{
    public class Negocios_Usuario
    {
        public static DataTable Verificar(string nombre_usuario, string contrasena_usuario)
        {
            Metodos_Usuario veri = new Metodos_Usuario();
            return veri.Verificar(nombre_usuario, contrasena_usuario);
        }
    }
}
