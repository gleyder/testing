<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Notificaciones.aspx.cs" Inherits="WebApp.Notificaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Mis Notificaciones<br />
        <br />
    
    </div>
        <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" Width="724px">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <ItemTemplate>
                Mensaje:
                <asp:Label ID="MensajeLabel" runat="server" Text='<%# Eval("Mensaje") %>' />
                <br />
                Tipo:
                <asp:Label ID="TipoLabel" runat="server" Text='<%# Eval("Tipo") %>' />
                <br />
                Fecha:
                <asp:Label ID="FechaLabel" runat="server" Text='<%# Eval("Fecha") %>' />
                <br />
<br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Mensaje], [Tipo], [Fecha] FROM [Notificaciones]" ></asp:SqlDataSource>
        <br />
        <br />
    </form>
</body>
</html>
