<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="QueryWebApp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: gainsboro; color: black; font-family:Calibri; margin: auto; width: 50%; padding: 5px;">
            <h3>QueryApp Login</h3>
            <asp:TextBox ID="txtUser" runat="server" placeholder="Usuario"></asp:TextBox><br />
            <asp:TextBox ID="txtPass" runat="server" TextMode="password" placeholder="Clave"></asp:TextBox><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
            <br />
            <asp:Label ID="lbMensaje" runat="server" Text=""></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>