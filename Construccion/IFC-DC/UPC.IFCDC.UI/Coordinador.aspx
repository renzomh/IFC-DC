<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Coordinador.aspx.cs" Inherits="UPC.IFCDC.UI.WebForm2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
<br />
<div class="box-central">
    <h1>INFORME DE FIN DE CICLO</h1>
    <p>Ciclo: <asp:Label ID="Ciclo" runat ="server" Text="TextoCiclo"></asp:Label></p>
    <p>Fecha Límite: <asp:Label ID="FechaLimite" Text="FechaLímite" runat ="server"></asp:Label></p>
    <p>Curso: <asp:Label ID="Curso" runat="server" Text="TextoCurso" ></asp:Label></p>
</div>
<ul class="tabs">
    <li onclick="change_view('#logros');" >Logros</li><li onclick="change_view('#accionesPrevias');" >Acciones Previas</li><li onclick="change_view('#hallazgos');" >Hallazgos</li><li onclick="change_view('#accionesMejora');" >Acciones de Mejora</li><li onclick="change_view('#comentario');" >Comentarios</li></ul>


<div id="logros" class="box-central">
    <h4>El Curso contribuye a alcanzar los siguientes Student Outcomes</h4>
    <table class="TablaNested">
    <thead><tr class="HeaderTabla"><th>Student Outcome</th><th>Descripción</th></tr></thead>
    <tbody>
        <tr><td>B</td><td>Diseña y conduce experimentos en base al análisis e interpretación de datos relevantes en la implementacion de soluciones de softare</td></tr>
        <tr><td>B</td><td>Diseña y conduce experimentos en base al análisis e interpretación de datos relevantes en la implementacion de soluciones de softare</td></tr>
    </tbody>
    </table>
    <h4>El Curso tiene planteado el siguiente logro terminal</h4>
    <asp:Label CssClass="disabled" Width="99%" ID="LogroTerminal" Text="Logro terminal del curso" runat="server"></asp:Label>
    <br /><br />
    <div style="text-align:center;">
    <asp:Button CssClass="btn-enviar" ID="btnEnviar" runat="server" />
    <asp:Button CssClass="btn-guardar" ID="btnGuardar" runat="server" />
    <asp:Button CssClass="btn-cancelar" ID="btnCancelar" runat="server" />
    </div>
</div>
<div id="accionesPrevias" class="box-central">
    accionesPrevias
</div>
<div id="hallazgos" class="box-central">
    Hallazgos
</div>
<div id="accionesMejora" class="box-central">
    Acciones de Mejora
</div>
<div id="comentario" class="box-central">
    Comentarios
</div>
</asp:Content>
