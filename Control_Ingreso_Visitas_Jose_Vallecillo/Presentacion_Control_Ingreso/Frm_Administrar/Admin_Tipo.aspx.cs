﻿using System;
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

        protected void Admin_tipo(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow dato = (GridViewRow)GridView1.Rows[e.RowIndex];
            Negocios_Tipo.Eliminar(int.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString()));
            GridView1.DataSource = Negocios_Tipo.Listar();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = Negocios_Tipo.Listar();
            GridView1.DataBind();
        }
    }
}