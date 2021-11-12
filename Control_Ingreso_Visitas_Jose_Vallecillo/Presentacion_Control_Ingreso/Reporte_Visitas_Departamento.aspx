<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_maestra/Sitio.Master" AutoEventWireup="true" CodeBehind="Reporte_Visitas_Departamento.aspx.cs" Inherits="Presentacion_Control_Ingreso.Reporte_Visitas_Departamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false"></asp:GridView>
    </center>
</asp:Content>
