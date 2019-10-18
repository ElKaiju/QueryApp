<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="QueryWebApp.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">s
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: gainsboro; color: black; font-family:Calibri; margin: auto; width: 50%; padding: 5px;">
            <h4>Página de Administrador</h4>
            <h5>Tickets disponibles:</h5>
            <asp:GridView ID="grdMensaje" runat="server">
            </asp:GridView><asp:Button ID="btnRespuesta" runat="server" Text="Responder"/>
        </div>
        <div style="background-color: gainsboro; color: black; font-family:Calibri; margin: auto; width: 50%; padding: 5px;">
            <h4>Opciones de Administrador:</h4>
            <asp:Button ID="btnAgregarUsuario" runat="server" Text="Agregar Usuario" OnClick="btnAgregar_Click"/>
            <asp:Button ID="btnEliminarUsuario" runat="server" Text="Eliminar Usuario"/>
            <asp:Button ID="btnEditarUsuario" runat="server" Text="Editar Usuario"/>
        </div>
    </form>
</body>
</html>
