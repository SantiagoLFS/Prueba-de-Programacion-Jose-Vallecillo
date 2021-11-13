<%@ Page Title="" Language="C#" MasterPageFile="Sitio.Master" AutoEventWireup="true" CodeBehind="Agregar_Departamento.aspx.cs" Inherits="Presentacion_Control_Ingreso.Agregar_Departamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Agregar Nuevo Departamento de la Empresa"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Visible="False" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre Departamento :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Txt_departamento" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Cancelar" />
    </center>
</asp:Content>
