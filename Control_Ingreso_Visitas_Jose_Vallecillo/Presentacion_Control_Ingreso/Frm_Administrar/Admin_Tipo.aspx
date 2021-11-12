<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_maestra/Sitio.Master" AutoEventWireup="true" CodeBehind="Admin_Tipo.aspx.cs" Inherits="Presentacion_Control_Ingreso.Admin_Tipo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_tipo_usuario" OnRowDeleting="Admin_tipo" >
            <Columns>
                <asp:BoundField DataField="id_tipo_usuario" HeaderText="Id Tipo de Usuario" />
                <asp:BoundField DataField="descrip_tipo_usuario" HeaderText="Descripcion de tipo de Usuario" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </center>
</asp:Content>
