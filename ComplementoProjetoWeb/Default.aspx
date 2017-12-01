<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ComplementoProjetoWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Fotografia</h1>
        <p class="lead">Visitar galeria de fotos.</p>
        <p><a href="Default.aspx" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Contato</h2>
            <p>
                Mantenha contato. 
            </p>
            <p>
                <a class="btn btn-default" href="Contact.aspx">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Galeria de fotos</h2>
            <p>
               Verifique nossa galeria de fotos
            </p>
            <p>
                <a class="btn btn-default" href="Galeria.aspx">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Sobre mim</h2>
            <p>
                Fique sabendo mais sobre mim.
            </p>
            <p>
                <a class="btn btn-default" href="About.aspx">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
