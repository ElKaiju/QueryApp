<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregarUsuario.aspx.cs" Inherits="QueryWebApp.agregarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: gainsboro; color: black; font-family:Calibri; margin: auto; width: 50%; padding: 5px;">
            <asp:TextBox ID="txtId" placeholder="Código Usuario" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="txtRut" placeholder="Rut" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="txtPassword" TextMode="Password" placeholder="Password"  runat="server"></asp:TextBox><br />
            <asp:TextBox ID="txtNombre" placeholder="Nombre"  runat="server"></asp:TextBox><br />
            <asp:TextBox ID="txtApellido" placeholder="Apellido"  runat="server"></asp:TextBox><br />
            <asp:TextBox ID="txtEdad" placeholder="Edad"  runat="server"></asp:TextBox><br />
            <asp:DropDownList ID="ddlSexo" runat="server">
                <asp:ListItem>Femenino</asp:ListItem>
                <asp:ListItem>Masculino</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:TextBox ID="txtTelefono" placeholder="Teléfono"  runat="server"></asp:TextBox><br />
            <asp:TextBox ID="txtEmail" placeholder="E-mail"  runat="server"></asp:TextBox><br />
            <asp:TextBox ID="txtTipoUsuario" placeholder="Tipo de Usuario"  runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
            <br />
            <asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
