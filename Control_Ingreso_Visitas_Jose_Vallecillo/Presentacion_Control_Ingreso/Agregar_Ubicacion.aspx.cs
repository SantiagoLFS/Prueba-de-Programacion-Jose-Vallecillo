using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios_Control_Ingresos;
namespace Presentacion_Control_Ingreso
{
    public partial class Agregar_Ubicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                resp = Negocios_Ubicacion.Insert_ubicacion(Txt_id_ubica.Text);
                if (resp.Equals("OK"))
                {
                    Txt_id_ubica.Text = "";
                }
            }
            catch
            {

            }
        }
    }
}