<%@ Page Title="Home Page" Language="C#" MasterPageFile="" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TextBox._Default" %>

<form id="form1" runat="server">
    <p>
        Single Line<br />
        <asp:TextBox ID="txtSingleLine" runat="server" ToolTip="Este es el más común de todos"></asp:TextBox>&nbsp;
        <asp:Label ID="lblSingleLine" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        ReadOnly<br /><asp:TextBox ID="txtReadOnly" runat="server" ReadOnly="True"></asp:TextBox>
    </p>
    <p>
        MaxLength (8)<br /><asp:TextBox ID="txtMaxLength" runat="server" MaxLength="8"></asp:TextBox>
    </p>
    <p>
        Columns (5)<br /><asp:TextBox ID="txtColumns" runat="server" Columns="5"></asp:TextBox>
    </p>
    <p>
        MultiLine (rows = 5)<br /><asp:TextBox ID="txtMultiLine" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox>
    </p>
    <p>
        Password<br /><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        Number<br /><asp:TextBox ID="txtNumber" runat="server" TextMode="Number"></asp:TextBox>
    </p>
    <p>
        Date<br /><asp:TextBox ID="txtDate" runat="server" TextMode="Date"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnPostBack" runat="server" Text="PostBack" OnClick="btnPostBack_Click" />
    </p>
</form>


