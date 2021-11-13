using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios_Control_Ingresos;
namespace Presentacion_Control_Ingreso
{
    public partial class Agregar_Visita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             Negocios_Visita.Insert_visita(TextBox1.Text , TextBox2.Text, TextBox3.Text);
        }
    }
}