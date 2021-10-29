<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsoViewState.aspx.cs" Inherits="Estado_ConViewState.UsoViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblIncremento" runat="server" Text="Incremento"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtContador" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnIncrementar" runat="server" Text="Incrementar" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
