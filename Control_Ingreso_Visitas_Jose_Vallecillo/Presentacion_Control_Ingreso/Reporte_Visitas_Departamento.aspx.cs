using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios_Control_Ingresos;
namespace Presentacion_Control_Ingreso
{
    public partial class Reporte_Visitas_Departamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            GridView1.DataSource = Negocios_Reporte.Buscar(Calendar1.SelectedDate,Calendar2.SelectedDate);
            GridView1.DataBind();
        }
    }
}