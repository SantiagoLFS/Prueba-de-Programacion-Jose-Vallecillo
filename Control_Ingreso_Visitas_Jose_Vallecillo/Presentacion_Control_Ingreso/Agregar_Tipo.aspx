<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_maestra/Sitio.Master" AutoEventWireup="true" CodeBehind="Agregar_Tipo.aspx.cs" Inherits="Presentacion_Control_Ingreso.Agregar_Tipo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <asp:Label ID="Label1" runat="server" Text="Agregar Nuevo tipo de Usuario"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="Txt_tipo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
        <asp:Button ID="Button2" runat="server" Text="Cancelar" />
    </center>
</asp:Content>
