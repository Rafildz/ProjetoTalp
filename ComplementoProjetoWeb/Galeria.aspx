<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Galeria.aspx.cs" Inherits="ComplementoProjetoWeb.Galeria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <div>
       <asp:Label Text="" ID="lblImagem" runat="server" />
   </div>
   <div>
       <div>
        <img src="Fotos/1.jpg" style="width: 200px; height:100px"/> <a class="btn btn-default" href="Foto?id=1">Visualizar</a>
       </div><div>
        <img src="Fotos/2.jpg" style="width: 200px; height:100px"/><a class="btn btn-default" href="Foto?id=2">Visualizar</a>
       </div><div>
        <img src="Fotos/3.jpg" style="width: 200px; height:100px"/><a class="btn btn-default" href="Foto?id=3">Visualizar</a>
       </div><div>
        <img src="Fotos/4.jpg" style="width: 200px; height:100px"/><a class="btn btn-default" href="Foto?id=4">Visualizar</a>
       </div><div>
        <img src="Fotos/5.jpg" style="width: 200px; height:100px"/><a class="btn btn-default" href="Foto?id=5">Visualizar</a>
       </div><div>
        <img src="Fotos/6.jpg" style="width: 200px; height:100px"/><a class="btn btn-default" href="Foto?id=6">Visualizar</a>
       </div>
   </div>
</asp:Content>
