using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios_Control_Ingresos;
namespace Presentacion_Control_Ingreso
{
    public partial class Admin_Ubicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            GridView1.DataSource = Negocios_Ubicacion.Listar();
            GridView1.DataBind();
        }

        protected void g_ubicacion(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow llenar = (GridViewRow)GridView1.Rows[e.RowIndex];
            Negocios_Ubicacion.Eliminar_Ubicacion(int.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString()));
            GridView1.DataSource = Negocios_Ubicacion.Listar();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = Negocios_Ubicacion.Buscar(TextBox1.Text);
            GridView1.DataBind();
        }
    }
}