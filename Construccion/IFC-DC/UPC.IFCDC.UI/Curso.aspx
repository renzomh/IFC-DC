<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Curso.aspx.cs" Inherits="UPC.IFCDC.UI.WebForm3" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <br />
<div class="box-central">
    <h1>CURSOS</h1>
    <p>Ciclo: <asp:Label ID="Ciclo" runat ="server" Text="TextoCiclo"></asp:Label></p>
    <p>Fecha Límite: <asp:Label ID="FechaLimite" Text="FechaLímite" runat ="server"></asp:Label></p>

<table class="TablaNested">
    <thead><tr class="HeaderTabla"><th>Código</th><th>Nombre</th><th>Informe</th></tr></thead>
    <tbody>
        <tr><td>SI254</td><td>EVOLUCION DE SOFTWARE</td><td><asp:Button CssClass="btn-informe" runat="server" ID="btnInforme01" /> </td></tr>
        <tr><td>SI37</td><td>ARQUITECTURA DE SOFTWARE</td><td><asp:Button CssClass="btn-informe" runat="server" ID="Button1" /></td></tr>
    </tbody>
    </table>
</div>
</asp:Content>
