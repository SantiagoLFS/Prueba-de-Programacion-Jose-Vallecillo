using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios_Control_Ingresos;
namespace Presentacion_Control_Ingreso
{
    public partial class Admin_Tipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gh_Admin_tipo(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow dato = (GridViewRow)gv_Tipo.Rows[e.RowIndex];
            Negocios_Tipo.Eliminar(int.Parse(gv_Tipo.DataKeys[e.RowIndex].Value.ToString()));
            gv_Tipo.DataSource = Negocios_Tipo.Listar();
            gv_Tipo.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            gv_Tipo.DataSource = Negocios_Tipo.Listar();
            gv_Tipo.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            gv_Tipo.DataSource = Negocios_Tipo.Buscar(TextBox1.Text);
            gv_Tipo.DataBind();
        }
    }
}