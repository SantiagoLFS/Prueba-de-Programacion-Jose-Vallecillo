<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina_maestra/Sitio.Master" AutoEventWireup="true" CodeBehind="Admin_Departamento.aspx.cs" Inherits="Presentacion_Control_Ingreso.Admin_Departamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="id_departamento" OnRowDeleting="g_Admin_Departamento" Width="509px">
            <Columns>
                <asp:BoundField DataField="Id_departamento" HeaderText="Id Departamento" />
                <asp:BoundField DataField="Nombre_departamento" HeaderText="Nombre Departamento" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField CancelText="" DeleteText="" EditText="Actualizar" InsertText="" NewText="" SelectText="" ShowEditButton="True" />
            </Columns>
            
        </asp:GridView>
    </center>
    </asp:Content>
