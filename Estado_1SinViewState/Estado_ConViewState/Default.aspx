<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Estado_ConViewState._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:TextBox ID="txtContador" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnIncrementar" runat="server" OnClick="btnIncrementar_Click" Text="Incrementar" />
        <br />
    </p>
    <p>
        <br />
    </p>
</asp:Content>
