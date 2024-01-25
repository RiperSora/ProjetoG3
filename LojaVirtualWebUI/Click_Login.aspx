<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Click_Login.aspx.cs" Inherits="LojaVirtualWebUI.Click_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="height: 276px">
        
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="Larger" Text="Login"></asp:Label><br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Senha:"></asp:Label>
        <asp:TextBox ID="TxtSenha" runat="server"></asp:TextBox> <br /> 
        <br />
        <asp:Button ID="BtnLogar" runat="server" Text="Entrar" />
    </div>
</asp:Content>
