<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ControlBulletList.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="LowerRoman" FirstBulletNumber="5">
                <asp:ListItem Value="ec">Ecuador</asp:ListItem>
                <asp:ListItem Value="co">Colombia</asp:ListItem>
                <asp:ListItem Value="pe">Perú</asp:ListItem>
                <asp:ListItem Value="ca">Canadá</asp:ListItem>
            </asp:BulletedList>
        </div>
        <asp:BulletedList ID="BulletedList2" runat="server" DisplayMode="HyperLink">
            <asp:ListItem Value="www.google.com">Google</asp:ListItem>
            <asp:ListItem Value="www.microsoft.com">Microsoft</asp:ListItem>
            <asp:ListItem Value="www.yahoo.com">Yahoo</asp:ListItem>
        </asp:BulletedList>
        <asp:BulletedList ID="blCiudades" runat="server" DisplayMode="LinkButton" OnClick="BulletedList3_Click">
            <asp:ListItem Value="uio">Quito</asp:ListItem>
            <asp:ListItem Value="bog">Bogotá</asp:ListItem>
            <asp:ListItem Value="lax">Los Ángles</asp:ListItem>
        </asp:BulletedList>
        <asp:Label ID="lblCiudades" runat="server"></asp:Label>
    </form>
</body>
</html>
