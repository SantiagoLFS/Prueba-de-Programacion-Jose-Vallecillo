<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_maestra/Panel_Control.Master" AutoEventWireup="true" CodeBehind="Agregar_Empleado.aspx.cs" Inherits="Presentacion_Control_Ingreso.Agregar_Empleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<asp:TextBox ID="Txt_id" runat="server"></asp:TextBox>
<br />
<br />
<asp:TextBox ID="Txt_nombre" runat="server"></asp:TextBox>
<br />
<br />
<asp:TextBox ID="Txt_apellido" runat="server" OnTextChanged="Txt_apellido_TextChanged"></asp:TextBox>
<br />
<br />
<asp:Button ID="Btn_agregar" runat="server" Text="Agregar Empleado" OnClick="Btn_agregar_Click" />
</asp:Content>
