<%@ Page Title="" Language="C#" MasterPageFile="Sitio.Master" AutoEventWireup="true" CodeBehind="Admin_Departamento.aspx.cs" Inherits="Presentacion_Control_Ingreso.Admin_Departamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center style="height: 459px">
        <br />
        <asp:Label ID="Label1" runat="server" Text="Busca los Departamentos por nombre"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="Txt_busca" runat="server" Width="288px" EnableViewState="true" OnTextChanged="Txt_busca_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Buscar" Width="147px" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cargar Todos los Departamentos" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="id_departamento" OnRowDeleting="g_Admin_Departamento" Width="764px" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" OnRowEditing="GridView1_RowEditing">
            <Columns>
                <asp:BoundField DataField="Id_departamento" HeaderText="Id Departamento" />
                <asp:BoundField DataField="Nombre_departamento" HeaderText="Nombre Departamento" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton Id="DActualizar" runat="server" Text="Actualizar" OnClick="DActualizar_Click"></asp:LinkButton> 
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
            
        </asp:GridView>
        <panel id="pnDepartamento" runat="server" Visible="false">
            <div>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Actualizar datos departamento"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Id Departamento :"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Txt_id" runat="server" Enabled="False" Width="216px"></asp:TextBox>
                <br />
            </div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="Nombre Departamento :"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Txt_nombre" runat="server" style="margin-left: 0px" Width="215px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" Text="Actualizar" OnClick="Button3_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" Text="Cancelar" OnClick="Button4_Click"/>
            </div>
            <div>

            </div>
        </panel>
    </center>
    </asp:Content>
