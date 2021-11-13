<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Presentacion_Control_Ingreso.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 275px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" posicion="center">
        <div>
            <center>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Ingrese su usuario y clave"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Usuario :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Width="222px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Contraseña :"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="222px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Ingresar " OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Cancelar" />
            </center>
        </div>
    </form>
</body>
</html>
