<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Informe.aspx.cs" Inherits="UPC.IFCDC.UI.WebForm2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <br />
<div class="box-central">
    <h1>INFORME DE FIN DE CICLO</h1>
    <p>Ciclo: <asp:Label ID="texto_PeriodoActual" runat ="server" Text="TextoCiclo"></asp:Label></p>
    <p>Fecha Límite: <asp:Label ID="texto_FechaLimite" Text="FechaLímite" runat ="server"></asp:Label></p>
    <p>Curso: <asp:Label ID="texto_DescripcionCurso" runat="server" Text="TextoCurso" ></asp:Label></p>
</div>
<ul class="tabs">
    <li onclick="change_view('#logros');" >Logros</li><li onclick="change_view('#accionesPrevias');" >Acciones Previas</li><li onclick="change_view('#hallazgos');" >Hallazgos</li><li onclick="change_view('#accionesMejora');" >Acciones de Mejora</li><li onclick="change_view('#comentario');" >Comentarios</li>
 </ul>


<div id="logros" class="box-central">
    <h4>El Curso contribuye a alcanzar los siguientes Student Outcomes</h4>
    <table class="TablaNested">
    <tbody>
        <tr>
        <td colspan="2" align="center" >
            <asp:GridView ID="grdOutcomes" runat="server" Width="100%"
             CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false"> 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Student Outcome" DataField="Outcome" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Descripción" DataField="Descricpion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="80%"/>                    
                </Columns>
             
            </asp:GridView>
        </td>
    </tr>
    </tbody>
    </table>
    <h4>El Curso tiene planteado el siguiente logro terminal</h4>
    <asp:Label CssClass="disabled" Width="99%" ID="texto_LogroTerminal" Text="Logro terminal del curso" runat="server"></asp:Label>
</div>
<div id="accionesPrevias" class="box-central">
     <asp:GridView ID="grdAccionesPrevias" runat="server" Width="100%"
             CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false" 
                > 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Código" DataField="Codigo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Descripción" DataField="Descricpion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="60%"/>
                    <asp:BoundField HeaderText="Estado" DataField="Estado" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20%"/>                    
                </Columns>
                
             
            </asp:GridView>
</div>
<div id="hallazgos" class="box-central">
    <table class="TablaNested">
    <tbody>
        <tr>
        <td colspan="2" align="center" >
            <asp:GridView ID="grdHallazgos" runat="server" Width="100%" CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false"> 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Código" DataField="Codigo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Descripción" DataField="Descripcion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="60%"/>
                
                </Columns>
                   
            </asp:GridView>
        </td>
        </tr>
    </tbody>
    </table>
    <button type="button" onclick="popup('#pHallazgo');">Nuevo Hallazgo</button>
</div>
<div id="accionesMejora" class="box-central">
     <asp:GridView ID="grdAccionesdeMejora" runat="server" Width="100%"
             CellPadding="4" CellSpacing="1" Border="0" AutoGenerateColumns="false" 
                > 
                <RowStyle CssClass="grdFilas"/>
                <HeaderStyle CssClass="grdCabecera"/>
                <AlternatingRowStyle CssClass="grdFilasAlternas"/>
             
                <Columns>                    
                    <asp:BoundField HeaderText="Código" DataField="Codigo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Descripción" DataField="Descricpion" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="30%"/>
                    <asp:BoundField HeaderText="Ciclo" DataField="Ciclo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%"/>
                    <asp:BoundField HeaderText="Hallazgo" DataField="Hallazgo" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20%"/>
                    <asp:BoundField HeaderText="Editar" DataField="Editar" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%"/>
                    <asp:BoundField HeaderText="Eliminar" DataField="Eliminar" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%"/>
                </Columns>
                
             
            </asp:GridView>
</div>
<div id="comentario" class="box-central">
    Comentarios
</div>

<br /><br />
    <div style="text-align:center;">
    <asp:Button CssClass="btn-enviar" ID="btnEnviar" runat="server" />
    <asp:Button CssClass="btn-guardar" ID="btnGuardar" runat="server" />
    <asp:Button CssClass="btn-cancelar" ID="btnCancelar" runat="server" />
    </div>
<!-- ZONA DE POPUPS -->
<div class="dark-side">
    <div class="pop-up" id="pAccionesMejora"><div class="pHeader">Acciones de Mejora <div class="pClose">&times;</div></div>Contenido</div>
    <div class="pop-up" id="pHallazgo">
        <div class="pHeader">Hallazgo<div class="pClose" onclick="close_popup('#pHallazgo');">&times;</div></div>
        <div class="contentP"><asp:TextBox Width="400px" Height="200px" runat="server"> </asp:TextBox> <br /> <br /><asp:TextBox> <asp:Button ID="btnAgregarH" runat="server" CssClass="btn-agregar" /> <asp:Button ID="btnCancelarH" runat="server" CssClass="btn-cancelar" /></div>
     </div>
</div>
</asp:Content>
