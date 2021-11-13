<%@ Page Title="" Language="C#" MasterPageFile="Sitio.Master" AutoEventWireup="true" CodeBehind="Agregar_Ubicacion.aspx.cs" Inherits="Presentacion_Control_Ingreso.Agregar_Ubicacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Agregar Nueva Ubicacion"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre ubicacion :"></asp:Label>
        <asp:TextBox ID="Txt_id_ubica" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Btn_agregar" runat="server" Text="Agregar" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btn_cancelar" runat="server" Text="Cancelar" />
    </center>
</asp:Content>
