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
                GridView1.DataSource = Negocios_Departamento.Buscar(Txt_busca.Text);
                GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void DActualizar_Click(object sender, EventArgs e)
        {
            pnDepartamento.Visible = true;
            Button3.Visible = true;
            GridViewRow row = (GridViewRow)((LinkButton)sender).Parent.Parent;
            Txt_id.Text = row.Cells[0].Text;
            Txt_nombre.Text  = row.Cells[1].Text;
        }
        private void actualizar(long id_depat, string nombre)
        {
            Negocios_Departamento.Insert_departamento(int.Parse(id_depat.ToString()), nombre);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            actualizar(int.Parse(Txt_id.Text), Txt_nombre.Text);
            GridView1.DataSource = Negocios_Departamento.Listar();
            GridView1.DataBind();
            pnDepartamento.Visible = false;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            pnDepartamento.Visible = false;
        }

        protected void Txt_busca_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}