<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ComplementoProjetoWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Contato</h2>
   <p>
        Envia E-mail</p>
    <p>
        Nome:</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        E-mail:</p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Assunto:</p>
    <p>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="20 Fotos" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" Text="40 Fotos" />
&nbsp;<asp:RadioButton ID="RadioButton3" runat="server" Text="60 Fotos" />
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click"/>
    </p>
</asp:Content>
