<%@ Page Title="Home Page" Language="C#" MasterPageFile="" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlCheckBox._Default" %>
<form id="form1" runat="server">
Restaurant ComaComa

Costo plato estándar <asp:TextBox id="txtPrecio" text="8" runat="server" columns="5"></asp:TextBox>
<br /><br />
Extras: <br />
    <asp:CheckBox ID="chkPapas" runat="server" text="Papas" /> 
    &nbsp;&nbsp;&nbsp;Costo
    <asp:TextBox runat="server" id ="txtPapas" columns="4">1.5</asp:TextBox>
    <br />
    <asp:CheckBox ID="chkBebida" runat="server" text="Bebida" />
    &nbsp;&nbsp;&nbsp;Costo
    <asp:TextBox runat="server" id ="txtBebida" columns="4">0.8</asp:TextBox>
    <br />
    <asp:CheckBox ID="chkPostre" runat="server" text="Postre" />
    &nbsp;&nbsp;&nbsp;Costo
    <asp:TextBox runat="server" id ="txtPostre" columns="4">2.0</asp:TextBox>
    <br />
    <asp:CheckBox ID="chkIva" runat="server" text="IVA" AutoPostBack="True" Checked="True" OnCheckedChanged="chkIva_CheckedChanged" />
    &nbsp;&nbsp;&nbsp;Costo
    <asp:TextBox runat="server" id ="txtIva" columns="4">12</asp:TextBox>%
    <br />
    <br />
    <asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnTotal" runat="server" Text="Calcular Total" OnClick="btnTotal_Click" />
</form>



