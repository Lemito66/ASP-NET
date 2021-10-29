<%@ Page Title="Home Page" Language="C#" MasterPageFile="" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RadioButton._Default" %>


<form id="form1" runat="server">
    Elija el pa&iacute;s<br />
    <asp:RadioButton ID="rbEcuador" runat="server" GroupName="Pais" Text="Ecuador" Checked="True" /><br />
    <asp:RadioButton ID="rbColombia" runat="server" GroupName="Pais" Text="Colombia" /><br />
    <asp:RadioButton ID="rbPeru" runat="server" GroupName="Pais" Text="Perú" />
    <br />
    <asp:Button ID="btnProcesar" runat="server" Text="Elegir País" OnClick="btnProcesar_Click" />
    <br />
    <br />
    <asp:Label runat="server" ID="lblPais"></asp:Label>
    <br />
    <br />
    <br />
    Elija el g&eacute;nero<br />
    <asp:RadioButton ID="rbMasculino" runat="server" GroupName="Genero" Text="Masculino" AutoPostBack="True" OnCheckedChanged="rbMasculino_CheckedChanged" /><br />
    <asp:RadioButton ID="rbFemenino" runat="server" GroupName="Genero" Text="Femenino" AutoPostBack="True" OnCheckedChanged="rbFemenino_CheckedChanged" /><br />
    <asp:RadioButton ID="rbNoDice" runat="server" GroupName="Genero" Text="Prefiero no decir" Checked="True" AutoPostBack="True" OnCheckedChanged="rbNoDice_CheckedChanged" />
    <br />
    <br />
    <asp:Label runat="server" ID="lblGenero"></asp:Label>
</form>



