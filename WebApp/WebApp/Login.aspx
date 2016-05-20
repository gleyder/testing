<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
    
        Ingresa a Tu Cuenta<br />
        <br />
        Matricula:<br />
        <asp:TextBox ID="TextMatricula" runat="server"></asp:TextBox>
        <br />
        <br />
        Contrasena:<br />
        <asp:TextBox ID="TextPass" runat="server" TextMode="Password"></asp:TextBox>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Conectarse" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Usuarios]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
