<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_maestra/Sitio.Master" AutoEventWireup="true" CodeBehind="Admin_Empleado.aspx.cs" Inherits="Presentacion_Control_Ingreso.Admin_Empleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_empleado" OnRowDeleting="Empleado" Width="638px">
            <Columns>
                <asp:BoundField DataField="Id_empleado" HeaderText="Id Empleado" />
                <asp:BoundField DataField="Nombre_empleado" HeaderText="Nombre Empleado" />
                <asp:BoundField DataField="Apellido_empleado" HeaderText="Apellido Empledo" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <br />
    </center>
</asp:Content>
