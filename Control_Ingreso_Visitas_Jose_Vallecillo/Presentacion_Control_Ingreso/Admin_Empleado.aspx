<%@ Page Title="" Language="C#" MasterPageFile="Sitio.Master" AutoEventWireup="true" CodeBehind="Admin_Empleado.aspx.cs" Inherits="Presentacion_Control_Ingreso.Admin_Empleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Busca los empleados por nombre o numero de identidad"></asp:Label>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="326px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Buscar" />
        <br />
&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Cargar todo los empleados registrados" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_empleado" OnRowDeleting="Empleado" Width="638px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id_empleado" HeaderText="Id Empleado" />
                <asp:BoundField DataField="Nombre_empleado" HeaderText="Nombre Empleado" />
                <asp:BoundField DataField="Apellido_empleado" HeaderText="Apellido Empledo" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <br />
    </center>
</asp:Content>
