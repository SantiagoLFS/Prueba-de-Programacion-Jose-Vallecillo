<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_maestra/Sitio.Master" AutoEventWireup="true" CodeBehind="Admin_Ubicacion.aspx.cs" Inherits="Presentacion_Control_Ingreso.Admin_Ubicacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_ubicacion" OnRowDeleting="g_ubicacion" >
            <Columns>
                <asp:BoundField DataField="id_ubicacion" HeaderText="Id Ubicacion" />
                <asp:BoundField DataField="descrip_ubicacion" HeaderText="Nombre Ubicacion" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </center>
</asp:Content>
