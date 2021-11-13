using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Web.UI.WebControls;
using Negocios_Control_Ingresos;
namespace Presentacion_Control_Ingreso
{
    public partial class Admin_Departamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = Negocios_Departamento.Listar();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void g_Admin_Departamento(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow llenar = (GridViewRow)GridView1.Rows[e.RowIndex];
            Negocios_Departamento.Eliminar_departamento(int.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString()));
            GridView1.DataSource = Negocios_Departamento.Listar();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
                GridView1.DataSource = Negocios_Departamento.Buscar(TextBox1.Text);
                GridView1.DataBind();
        }
    }
}